using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titanium : MonoBehaviour, Element
{
    Color color = new Color(0.14f, 0.25f, 0.32f);
    private int count;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Titanium;
    }

    public Titanium(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "Similar to aluminum, titanium is often used in spacecraft and aircraft due to its light weight, durability, and heat-resistance.\n Atomic Number: 22  Atomic Mass: 47.867";
    }

    public string toString()
    {
        return "Ti";
    }

    public int getCount()
    {
        return count;
    }
}
