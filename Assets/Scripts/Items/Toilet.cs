using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : Item
{
    private int count;
    public Toilet(int c)
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