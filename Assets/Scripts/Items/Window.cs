using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : Item
{
    private int count;
    public Window(int c)
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