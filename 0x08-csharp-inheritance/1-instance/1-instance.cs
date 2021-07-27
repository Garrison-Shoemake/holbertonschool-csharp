using System;
using System.Collections.Generic;

///<summary>Class object</summary>
class Obj
{
    ///<summary>Finds if an object is an instance of an array</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
        {
            return true;
        }
        return false;
    }
}

