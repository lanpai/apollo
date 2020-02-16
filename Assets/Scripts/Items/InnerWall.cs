using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerWall : MonoBehaviour, Item
{
    private int count;
    public InnerWall(int c)
    {
        count = c;
    }

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.InnerWall;
    }

    public string getDescription()
    {
        return "Separates the rooms, but is otherwise useless.";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Aluminum(1), new Titanium(1)};
        return elm;
    }
}