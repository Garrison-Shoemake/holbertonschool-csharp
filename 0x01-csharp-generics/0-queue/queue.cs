using System;

///<summary>New generic class Queue, emulating an actual Queue class</summary>
public class Queue<T>
{
    ///<summary>Returns the type of the Queue given</summary>
        public Type CheckType()
    {
        return typeof(T);
    }

}

