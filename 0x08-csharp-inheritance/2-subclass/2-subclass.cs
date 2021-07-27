using System;

///<summary>Class object</summary>
class Obj
{
    ///<summary>Checks if a class is a subclass</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType) == true) return true;
        return false;
    }
}

