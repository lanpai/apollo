using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laptop : MonoBehaviour, Item
{
    private int count;
    public Laptop(int c)
    {
        count = c;
    }

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Laptop;
    }

    public string getDescription()
    {
        return "Torture device for the hackathon. Key to success. Key to no sleep.";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Carbon(1), new Germanium(1)};
        return elm;
    }

    public string toString()
    {
        return "Laptop";
    }
}