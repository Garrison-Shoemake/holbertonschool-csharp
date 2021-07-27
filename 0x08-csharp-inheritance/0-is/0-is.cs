using System;

///<summary>Object class</summary>
class Obj
{
    ///<summary>Finds if an object is of type int</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
        {
            return true;
        }
        return false;
    }
}
