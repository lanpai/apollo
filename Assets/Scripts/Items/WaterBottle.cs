using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBottle : Item
{
    private int count;
    public WaterBottle(int c)
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