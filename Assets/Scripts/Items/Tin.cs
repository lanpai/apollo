using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tin : MonoBehaviour, Element
{
    Color color = new Color(0.39f, 0.63f, 0.80f);
    private int count;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Tin;
    }

    public Tin(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Tin was essential during the Bronze Age, making up the bronze with a mixture of itself and copper.\nAtomic Number: 50  Atomic Mass: 118.71";
    }

    public string toString()
    {
        return "Sn";
    }

    public int getCount()
    {
        return count;
    }
}
