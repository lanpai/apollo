using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelStorage : Item
{
    private int count;
    public FuelStorage(int c)
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