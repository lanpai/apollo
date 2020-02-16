﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : Item
{
    private int count;
    public Oven(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = { new Iron(2), new Carbon(1) };
        return elm; 
    }
}
