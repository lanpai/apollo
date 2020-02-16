using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : MonoBehaviour, Item
{
    public Color color = new Color(0.29f, 0.29f, 0.29f );
    private int count;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Oven;
    }

    public Oven(int c) => count = c;

    public string getDescription() => "It- It's an oven. It cooks stuff..";

    public int getCount() => count;

    public Element[] getElements()
    {
        Element[] elm = { new Iron(2), new Carbon(1) };
        return elm; 
    }

    public string toString()
    {
        return "Oven";
    }
}
