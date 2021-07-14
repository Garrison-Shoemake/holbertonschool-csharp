using System;

class Character
{
    public static bool IsLower(char c)
    {
        if ((int)c > 96 && (int)c < 123)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}
