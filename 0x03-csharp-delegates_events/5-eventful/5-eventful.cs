using System;
///<summary>Player class</summary>
public class Player
{
    string name;
    float maxHp;
    float hp;
    string status;

///<summary>Player constructor.</summary>
    public Player(string name="Player", float maxHp=100f)
    {
        this.status = $"{this.name} is ready to go!";
        this.name = name;
        HPCheck += CheckStatus;
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
        OnCheckStatus(new CurrentHPArgs(this.hp));
    }
    ///<summary>Applies the enum modfier to health</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak) return baseValue * 0.5f;
        if (modifier == Modifier.Strong) return baseValue * 1.5f;
        else return baseValue;
    }

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp) System.Console.WriteLine($"{this.name} is in perfect health!");
        if (e.currentHp < this.maxHp && e.currentHp >= (this.maxHp * 0.5f)) System.Console.WriteLine($"{this.name} is doing well!");
        if (e.currentHp >= (this.maxHp * 0.25f) && e.currentHp < (this.maxHp * 0.5f)) System.Console.WriteLine($"{this.name} isn't doing too great...");
        if (e.currentHp > 0 && e.currentHp < (this.maxHp * 0.25f)) System.Console.WriteLine($"{this.name} needs help!");
        if (e.currentHp == 0) System.Console.WriteLine($"{this.name} is knocked out!");
    }
    ///<summary>Status check for heal warning event</summary>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < (this.maxHp * 0.25f)) HPCheck += HPValueWarning;
        HPCheck(this, e);
    }
    ///<summary>Event warning for low health</summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0) System.Console.WriteLine("Health has reached zero!");
        else System.Console.WriteLine("Health is low!");
    }
    ///<summary>Event handler for HPCheck</summary>
    public event EventHandler<CurrentHPArgs> HPCheck;
}

///<summary>New event class for handling HP</summary>
public class CurrentHPArgs : EventArgs
{
    ///<summary>CurrentHP for event</summary>
    public readonly float currentHp;
    ///<summary>Constructor for currentHP</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

///<summary>Delegate for modificer calculation</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary>Enum list for modifier</summary>
public enum Modifier
{
    ///<summary>WEAKLING</summary>
    Weak,
    ///<summary>BASELING</summary>
    Base,
    ///<summary>STRONGLING</summary>
    Strong
}