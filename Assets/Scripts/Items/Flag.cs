using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : Item
{
    private int count;
    public Flag(int c)
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