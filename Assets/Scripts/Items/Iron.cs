using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : MonoBehaviour, Element
{
    Color color = new Color(.53f, 0.25f, 0f);
    private int count;
    public Iron(int c)
    {
        count = c;
    }

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Iron;
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