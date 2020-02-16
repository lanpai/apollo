using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygen : Element
{
    private int count;

    public Oxygen(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Oxygen, it's what we breathe.\nAtomic Number: 8  Atomic Mass: 15.999";
    }

    public string getSymbol()
    {
        return "O";
    }

    public int getCount()
    {
        return count;
    }
}
