using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : Item
{
    private int count;
    public Radio(int c)
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