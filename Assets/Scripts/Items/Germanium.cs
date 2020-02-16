using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Germanium : MonoBehaviour, Element
{
    private int count;

    public Germanium(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Germanium makes up transistors which are the most important invention in the age of information.\nAtomic Number: 32  Atomic Mass: 72.630";
    }

    public string getSymbol()
    {
        return "Ge";
    }

    public int getCount()
    {
        return count;
    }
}
