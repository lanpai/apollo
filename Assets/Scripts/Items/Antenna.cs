using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antenna : Item
{
    private int count;
    public Antenna(int c)
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