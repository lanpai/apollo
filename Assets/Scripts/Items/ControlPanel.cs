using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanel : Item
{
    private int count;
    public ControlPanel(int c)
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