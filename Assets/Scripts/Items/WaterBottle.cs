using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBottle : MonoBehaviour, Item
{
    private int count;
    public WaterBottle(int c)
    {
        count = c;
    }

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.WaterBottle;
    }

    public string getDescription()
    {
        return "Holds water.";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Carbon(1), new Iron(1), new Hydrogen(2), new Oxygen(1)};
        return elm;
    }
}