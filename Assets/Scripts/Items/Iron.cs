using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : Element
{
    private int count;
    public Iron(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        //TODO
        return "This is Iron. Not finished!";
    }

    public int getCount()
    {
        return count;
    }

    public string getSymbol() => "Fe";
}