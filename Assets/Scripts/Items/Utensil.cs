﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utensil : MonoBehaviour, Item
{
    private int count;
    public Utensil(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "Eating with utensils are for the weak.";
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