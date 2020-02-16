using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mattress : Item
{
    private int count;
    public Mattress(int c)
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