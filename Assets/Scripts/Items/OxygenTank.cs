using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTank : Item
{
    private int count;
    public OxygenTank(int c)
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
