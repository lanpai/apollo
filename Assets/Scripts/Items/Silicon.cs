using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silicon : Element
{
    private int count;

    public Silicon(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Computer chips are made with silicon, hence the name Silicon Valley.\nAtomic Number: 14  Atomic Mass: 28.085";
    }

    public string getSymbol()
    {
        return "Si";
    }

    public int getCount()
    {
        return count;
    }
}
