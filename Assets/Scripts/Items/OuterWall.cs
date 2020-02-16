using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterWall : Item
{
    private int count;
    public OuterWall(int c)
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