using System;
using System.Collections.Generic;
using System.Reflection;

///<summary>Class object</summary>
class Obj
{
    ///<summary>Prints names of available properties</summary>
    public static void Print(object myObj)
    {
        
        PropertyInfo[] properties = myObj.GetType().GetProperties();
        MethodInfo[] methods = myObj.GetType().GetMethods();

        System.Console.WriteLine(myObj.GetType().Name + " Properties:");
        foreach (PropertyInfo property in properties)
        {
            System.Console.WriteLine(property.Name);
        }
        System.Console.WriteLine(myObj.GetType().Name + " Methods:");
        foreach (MethodInfo method in methods)
        {
            System.Console.WriteLine(method.Name);
        }
    
    }
}

