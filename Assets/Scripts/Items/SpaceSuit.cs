using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceSuit : MonoBehaviour, Item
{
    private int count;
    public SpaceSuit(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "Ain't nobody want to see what's under.";
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