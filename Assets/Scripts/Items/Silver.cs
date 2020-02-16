using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silver : MonoBehaviour, Element
{
    private int count;

    public Silver(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Silver has antibiotic properties and is used by witchers to kill stuff.\nAtomic Number: 47  Atomic Mass: 107.87";
    }

    public string getSymbol()
    {
        return "Ag";
    }

    public int getCount()
    {
        return count;
    }
}
