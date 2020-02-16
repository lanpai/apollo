using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Self : MonoBehaviour, Item
{
    private int count;
    public Self(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "You, you, you, you, you.";
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