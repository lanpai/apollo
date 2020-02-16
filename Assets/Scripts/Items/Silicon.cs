using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silicon : MonoBehaviour, Element
{
    Color color = new Color(0.32f, 0.41f, 0.47f);
    private int count;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Silicon;
    }

    public Silicon(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Computer chips are made with silicon, hence the name Silicon Valley.\nAtomic Number: 14  Atomic Mass: 28.085";
    }

    public string getSymbol()
    {
        return "Si";
    }

    public int getCount()
    {
        return count;
    }
}
