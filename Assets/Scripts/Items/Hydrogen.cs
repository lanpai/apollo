using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydrogen : MonoBehaviour, Element
{
    Color color = new Color(0.47f, 0.45f, 1f);
    private int count;

    public Hydrogen(int c)
    {
        count = c;
    }

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Hydrogen;
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
