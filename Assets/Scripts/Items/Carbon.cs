using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carbon : Element
{
    private int count;
    public Carbon(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        //TODO
        return "This is Carbon. Not finished!";
    }

    public int getCount()
    {
        return count;
    }

    public string getSymbol() => "C";
}