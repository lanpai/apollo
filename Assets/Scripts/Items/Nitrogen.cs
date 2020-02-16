using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nitrogen : MonoBehaviour, Element
{
    private int count;

    public Nitrogen(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Nitrogen makes up 78% of our atmosphere.\nAtomic Number: 7  Atomic Mass: 14.007";
    }

    public string getSymbol()
    {
        return "N";
    }

    public int getCount()
    {
        return count;
    }
}
