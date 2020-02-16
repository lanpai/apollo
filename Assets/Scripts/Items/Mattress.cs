using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mattress : MonoBehaviour, Item
{
    Color color = new Color(1f, 1f, 1f);
    private int count;
    public Mattress(int c)
    {
        count = c;
    }

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Mattress;
    }

    public string getDescription()
    {
        return "Some people eat this stuff. My Strange Addictions...";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Carbon(8), new Hydrogen(8)};
        return elm;
    }
}