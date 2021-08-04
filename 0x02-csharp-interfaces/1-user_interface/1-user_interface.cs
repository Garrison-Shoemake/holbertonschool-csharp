﻿using System;

///<summary>Base abstract class</summary>
abstract class Base
{
    public string name = "";

    public override string ToString() => $"{this.name} is a {this.GetType()}";
}

interface IInteractive
{
    void Interact();
}
interface IBreakable
{
    int durability {get; set;}
    void Break();
}
interface ICollectable
{
    bool isCollected {get; set;}
    void Collect();
}
class TestObject: Base, IInteractive, IBreakable, ICollectable
{
    public bool isCollected {get; set;}
    public int durability {get; set;}
    public void Interact()
    {

    }
    public void Break()
    {

    }
    public void Collect()
    {
        
    }

}