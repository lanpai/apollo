using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterWall : MonoBehaviour, Item
{
    Color color = new Color(0.01f, 0.15f, 0.15f);

    private int count;
    public OuterWall(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "Yeah, if you remove this, I don't know what to say...";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElement()
    {
        Element[] elm = {new Carbon(1), new Hydrogen(2)};
        return elm;
    }
}