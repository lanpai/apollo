using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDetonatingButton : MonoBehaviour, Item
{
    private int count;
    public SelfDetonatingButton(int c)
    {
        count = c;
    }

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.SelfDetonatingButton;
    }

    public string getDescription()
    {
        return "Don't know why it's on the spaceship. Just avoid it.";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Carbon(1), new Hydrogen(1)};
        return elm;
    }
}