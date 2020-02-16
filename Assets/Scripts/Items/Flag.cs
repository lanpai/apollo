using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour, Item
{
    public Color color = new Color(0.24f, 0.24f, 0.24f);

    private int count;

    public Flag(int c) => count = c;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Flag;
    }

    public string getDescription() => "Ya stick it to something and pretend to be proud of it.";

    public int getCount() => count;

    Element[] getElements()
    {
        Element[] e = { new Carbon(12), new Hydrogen(22), new Nitrogen(2), new Oxygen(2) };
        return e;
    }
}