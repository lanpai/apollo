using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour, Item
{
    private int count;
    public Radio(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "Who uses these things now? Lol.";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Copper(1), new Lithium(1), new Tin(1), new Silver(1), new Gold(1), new Nickel(1), new Aluminum(1)};
        return elm;
    }
}