using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titanium : Element
{
    private int count;

    public Titanium(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "Similar to aluminum, titanium is often used in spacecraft and aircraft due to its light weight, durability, and heat-resistance.\n Atomic Number: 22  Atomic Mass: 47.867";
    }

    public string getSymbol()
    {
        return "Ti";
    }

    public int getCount()
    {
        return count;
    }
}
