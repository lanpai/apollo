using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : Item
{
    private int count;
    public Engine(int c)
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