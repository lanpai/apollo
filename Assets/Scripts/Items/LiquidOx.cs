using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidOx : MonoBehaviour, Item
{
    public Color color = new Color(0f, 0.58f, 1f);
    private int count;

    public LiquidOx(int c) => count = c;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.LiquidOx;
    }

    public string getDescription() => "Second Necessity for space flight.";

    public int getCount() => count;

    public Element[] getElements()
    {
        Element[] elm = {new Oxygen(6) };
        return elm;
    }

    public string toString()
    {
        return "Liquid Oxygen";
    }
}