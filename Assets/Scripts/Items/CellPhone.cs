﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellPhone : Item
{
    private int count;
    public CellPhone(int c)
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