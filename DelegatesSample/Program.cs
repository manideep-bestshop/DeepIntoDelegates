using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSample
{
    // Defining Delegate
    public delegate void AddDelegate(int x,int y);
    public delegate string SayDelegate(string greet);
    internal class Program
    {
        public void AddNumbers(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        { 
            Program p = new Program();

            //instantiating delegates
            AddDelegate ad = new AddDelegate(p.AddNumbers);

            //calling methods by delegates
            ad(34, 34);

            SayDelegate sd = new SayDelegate(SayHello);
            // program.AddNumbers(23, 27);
            string n=sd("Manideep");
           // string str = Program.SayHello("Manideep");

            Console.WriteLine(n);

            Rectangle r = new Rectangle();
            RectDelegate rect = r.GetArea;
            rect +=r.GetPerimeter;

            rect(2, 5);


            GreetingsDelegate gd = delegate (string name)
            {

                return "Hello " + name + " A very good morning";
            };

            Console.WriteLine(gd.Invoke("Manideep")); 

            //lamda Expressions
            GreetingsDelegate g=(name)=>
            {

                return "Hello " + name + " A very good morning";
            };
            Console.WriteLine(g.Invoke("Manideep"));
        }
    }
}
