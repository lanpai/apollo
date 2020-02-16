using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : MonoBehaviour, Element
{
    private int count;
    public Iron(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "Iron, super important during the Industrial Revolution. Factories. WOOH!";
    }

    public int getCount()
    {
        return count;
    }

    public string getSymbol() => "Fe";
}