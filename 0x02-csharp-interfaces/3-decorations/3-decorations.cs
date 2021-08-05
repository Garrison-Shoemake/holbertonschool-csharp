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

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability {get; set;}

    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    public void Interact()
    {
        if (this.durability <= 0)
        {
            System.Console.WriteLine($"The {this.name} has been broken.");
            return;
        }
        if (isQuestItem == true)
        {
            System.Console.WriteLine($"You look at the {this.name}. There's a key inside.");
            return;
        }
        else
        {
            System.Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }
    public void Break()
    {
        if (this.durability > 0)
        {
            System.Console.WriteLine($"You hit the {this.name}. It cracks.");
            this.durability--;
            return;
        }
        if (this.durability == 0)
        {
            System.Console.WriteLine($"You smash the {this.name}. What a mess.");
            this.durability--;
            return;
        }
        if (this.durability < 0)
        {
            System.Console.WriteLine($"The {this.name} is already broken.");
            return;
        }
    }
}