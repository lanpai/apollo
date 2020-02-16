using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDetonatingButton : Item
{
    private int count;
    public SelfDetonatingButton(int c)
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