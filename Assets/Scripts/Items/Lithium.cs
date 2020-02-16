﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lithium : MonoBehaviour, Element
{
    Color color = new Color(0.01f, 1, 0.95f);
    private int count;

    public Lithium(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Lithium makes up our batteries. WOW!\nAtomic Number: 3  Atomic Mass: 6.94";
    }

    public string getSymbol()
    {
        return "Li";
    }

    public int getCount()
    {
        return count;
    }
}