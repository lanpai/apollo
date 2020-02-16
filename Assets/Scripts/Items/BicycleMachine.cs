using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleMachine : MonoBehaviour, Item
{
    public Color color = new Color(0.29f, 0.35f, 0.29f);

    private int count;
    public BicycleMachine(int c) => count = c;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.BicycleMachine;
    }

    public string getDescription() => "Used to keep people in shape. You should try it...";

    public int getCount() => count;

    public Element[] getElements()
    {
        Element[] elm = { new Iron(2), new Carbon(2), new Aluminum(1), new Titanium(1) };
        return elm;
    }
}