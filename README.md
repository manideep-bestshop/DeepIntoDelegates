Delegates:
----------
-its a type safe function pointer
-A delegate holds a reference of a method and then calls the method for execution

1. Define delegate

[AccessModifier] Delegate void/type DelegateName(paraeters);

public delegate void AddDelegate(int a,int b)

public void AddNumbers(int x,int y)

2.instantiating Delegate

//instantiating delegates

 Program p = new Program();
 AddDelegate ad = new AddDelegate(p.AddNumbers);
 
3.calling methods by delegates

 //calling methods by delegates
 ad(34, 34);
 
 MultiCast Delegate:
 -------------------
 -A delegate holding more than one references of methods.
 
 Anonymous Methods:
 ------------------
 -suggested when code volume is less..
 
 
