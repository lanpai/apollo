using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nickel : MonoBehaviour, Element
{
    Color color = new Color(1f, 0.95f, 0.33f);
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
