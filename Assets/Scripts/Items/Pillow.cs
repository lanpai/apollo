using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillow : MonoBehaviour, Item
{
    private int count;
    public Pillow(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "The cushiony heaven after a long day.";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Carbon(22), new Hydrogen(36), new Oxygen(2)};
        return elm;
    }
}