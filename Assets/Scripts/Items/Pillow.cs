﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillow : Item
{
    private int count;
    public Pillow(int c)
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
}