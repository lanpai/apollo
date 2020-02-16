using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seats : Item
{
    private int count;
    public Seats(int c)
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