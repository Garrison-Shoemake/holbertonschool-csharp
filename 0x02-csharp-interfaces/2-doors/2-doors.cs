using System;

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
class Door : Base, IInteractive
{
    public Door(string name="Door")
    {
        this.name = name;
    }
    public void Interact()
    {
        System.Console.WriteLine($"You try to open the {this.name}. It's locked.");
        return;
    }
}