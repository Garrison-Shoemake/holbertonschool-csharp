using System;

///<summary>Base abstract class</summary>
abstract class Base
{
    public string name = "";

    public override string ToString() => $"{this.name} is a {this.GetType()}";
}