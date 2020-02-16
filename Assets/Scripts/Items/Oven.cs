using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : Item
{
    public Color color = new Color(0.29f, 0.29f, 0.29f );
    private int count;

    public Oven(int c) => count = c;

    public string getDescription() => "It- It's an oven. It cooks stuff..";

    public int getCount() => count;

    public Element[] getElements()
    {
        Element[] elm = { new Iron(2), new Carbon(1) };
        return elm; 
    }
}
