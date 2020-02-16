using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tin : MonoBehaviour, Element
{
    private int count;

    public Tin(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Tin was essential during the Bronze Age, making up the bronze with a mixture of itself and copper.\nAtomic Number: 50  Atomic Mass: 118.71";
    }

    public string getSymbol()
    {
        return "Sn";
    }

    public int getCount()
    {
        return count;
    }
}
