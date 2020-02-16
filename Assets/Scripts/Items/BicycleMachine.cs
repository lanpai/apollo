using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleMachine : Item
{
    private int count;
    public BicycleMachine(int c)
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