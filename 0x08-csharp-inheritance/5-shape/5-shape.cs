using System;

///<summary>Base Class</summary>
public class Shape
{
    ///<summary>Throws exception</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

