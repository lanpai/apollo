using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour, Item
{
    public Color color = new Color(0.66f, 0.58f, 0.21f);

    private int count;
    public Engine(int c) => count = c;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Engine;
    }

    public string getDescription() => "Powers your craft. You probably don't want to mess with it. No - seriously.";

    public int getCount() => count;

    Element[] getElements()
    {
        Element[] e = { new Titanium(2), new Aluminum(8), new Oxygen(4), new Hydrogen(4) };
        return e;
    }
}