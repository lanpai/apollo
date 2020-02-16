using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerWall : Item
{
    private int count;
    public InnerWall(int c)
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