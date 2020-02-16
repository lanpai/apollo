using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nickel : Element
{
    private int count;

    public Nickel(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Nickel, even worse than pennies.\nAtomic Number: 28  Atomic Mass: 58.693";
    }

    public string getSymbol()
    {
        return "Ni";
    }

    public int getCount()
    {
        return count;
    }
}
