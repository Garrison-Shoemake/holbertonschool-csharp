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
        if (maxHp < 0)
        {
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");   
            this.maxHp = 100f;
            this.hp = 100f;
        }
        else
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
    }
    ///<summary>Prints the players health and max health</summary>
    public void PrintHealth() {System.Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");}

    delegate void CalculateHealth(float amount);

    ///<summary>Method for taking damage</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0) System.Console.WriteLine($"{this.name} takes 0 damage!");   
        else System.Console.WriteLine($"{this.name} takes {damage} damage!");  
        this.hp -= damage;
        ValidateHP(this.hp);
    }
    ///<summary>Method for healing damage</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0) System.Console.WriteLine($"{this.name} heals 0 HP!");
        else 
        {
            System.Console.WriteLine($"{this.name} heals {heal} HP!");
            this.hp += heal;
        }
         
        ValidateHP(this.hp);
    }
    ///<summary>Validates the total health of the player</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0) this.hp = 0;
        else if (newHp > this.maxHp) this.hp = this.maxHp;
        else this.hp = newHp;
    }
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak) return baseValue * 0.5f;
        if (modifier == Modifier.Strong) return baseValue * 1.5f;
        else return baseValue;
    }
}
public delegate float CalculateModifier(float baseValue, Modifier modifier);

public enum Modifier
{
    Weak,
    Base,
    Strong
}