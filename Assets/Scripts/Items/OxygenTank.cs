using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTank : MonoBehaviour, Item
{
    Color color = new Color(0.01f, 0.88f, 0.88f);
    private int count;
    public OxygenTank(int c)
    {
        count = c;
    }

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.OxygenTank;
    }

    public string getDescription()
    {
        return "Stores all the oxygen so that the astronauts can breathe. We can't breathe nothing else.";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Carbon(1), new Hydrogen(1)};
        return elm;
    }
}
