using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassCup : MonoBehaviour, Item
{
    private int count;
    public GlassCup(int c)
    {
        count = c;
    }

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.GlassCup;
    }

    public string getDescription()
    {
        return "What happened to the fly on the toilet seat? It got pissed off.";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Silicon(1), new Aluminum(2), new Oxygen(5)};
        return elm;
    }
}