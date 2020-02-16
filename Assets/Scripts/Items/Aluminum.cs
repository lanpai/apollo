using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aluminum : Element
{
    private int count;

    public Aluminum(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Aluminum is a main component of aircraft and spacecraft due to its durability, low weight, and heat-resistance.\nAtomic Number: 13  Atomic Mass: 26.982";
    }

    public string getSymbol()
    {
        return "Al";
    }

    public int getCount()
    {
        return count;
    }
}
