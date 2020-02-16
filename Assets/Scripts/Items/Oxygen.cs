using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygen : MonoBehaviour, Element
{
    Color color = new Color(0.01f, 1f, 1f);

    private int count;
    private ItemType type;

    public Oxygen(int c)
    {
        count = c;
    }

    public ItemType getType()
    {
        return ItemType.Oxygen;
    }

    public string getDescription()
    {
        return "Oxygen, it's what we breathe.\nAtomic Number: 8  Atomic Mass: 15.999";
    }

    public string toString()
    {
        return "O";
    }

    public int getCount()
    {
        return count;
    }
}
