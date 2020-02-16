using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copper : Element
{
    private int count;

    public Copper(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Copper is the third most consumed industrial metal in the world, with 75% of it being used for wires, cables, and electronics.\nAtomic Number: 29  Atomic Mass: 63.546";
    }

    public string getSymbol()
    {
        return "Cu";
    }

    public int getCount()
    {
        return count;
    }
}
