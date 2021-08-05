using System;
///<summary>Player class</summary>
public class Player
{
    string name;
    float maxHp;
    float hp;

///<summary>Player constructor.</summary>
    public Player(string name="Player", float maxHp=100f)
    {
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
        if (maxHp < 0)
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");   
    }
    ///<summary>Prints the players health and max health</summary>
    public void PrintHealth() {System.Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");}
}