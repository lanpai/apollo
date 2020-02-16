using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silver : MonoBehaviour, Element
{
    Color color = new Color(0.8f, 0.92f, 1f);
    private int count;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Silver;
    }

    public Silver(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Silver has antibiotic properties and is used by witchers to kill stuff.\nAtomic Number: 47  Atomic Mass: 107.87";
    }

    public string toString()
    {
        return "Ag";
    }

    public int getCount()
    {
        return count;
    }
}
