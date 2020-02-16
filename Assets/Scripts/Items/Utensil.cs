using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utensil : Item
{
    private int count;
    public Utensil(int c)
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