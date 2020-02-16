using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydrogen : Element
{
    private int count;

    public Hydrogen(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Hydrogen powers the sun.\nAtomic Number: 1  Atomic Mass: 1.008";
    }

    public string getSymbol()
    {
        return "H";
    }

    public int getCount()
    {
        return count;
    }
}
