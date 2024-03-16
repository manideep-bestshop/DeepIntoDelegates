using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSample
{
    public delegate void RectDelegate(int a,int b);
    internal class Rectangle
    {
        public void GetArea(int width, int height)
        {
            Console.WriteLine("Area of rectangle: "+(width*height));
        }
        public void GetPerimeter(int w,int h)
        {
            Console.WriteLine("Perimeter : "+2*(w+h));
        }
        
    }
}
