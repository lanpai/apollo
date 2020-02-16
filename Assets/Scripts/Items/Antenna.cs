using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antenna : Item
{
    private int count;
    public Antenna(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "Antennae are used tozzzzz- $$$%%% -nd recieeeee$$$ zz~~~ Hmmm. Reception seems to be terrible.";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = { new Iron(3) };
        return elm;
    }
}