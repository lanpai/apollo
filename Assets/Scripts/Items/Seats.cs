using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seats : MonoBehaviour, Item
{
    private int count;
    public Seats(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "Literally been in this chair for 13 hours...";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Carbon(13), new Hydrogen(16)};
        return elm;
    }
}