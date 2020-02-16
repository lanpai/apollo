﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mattress : MonoBehaviour, Item
{
    private int count;
    public Mattress(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "Some people eat this stuff. My Strange Addictions...";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Carbon(8), new Hydrogen(8)};
        return elm;
    }
}