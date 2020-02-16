using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laptop : Item
{
    private int count;
    public Laptop(int c)
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