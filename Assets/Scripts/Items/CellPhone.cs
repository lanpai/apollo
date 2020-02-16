using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellPhone : MonoBehaviour, Item
{
    public Color color = new Color(0.24f, 0.24f, 0.24f);

    private int count;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.CellPhone;
    }

    public CellPhone(int c) => count = c;

    public string getDescription() => "Maybe you'd find a way off this tin can if you put down yo dayum phone!";

    public int getCount() => count;

    public Element[] getElements()
    {
        Element[] elm = { new Copper(1), new Lithium(1), new Tin(1), new Gold(1), new Silver(1), new Nickel(1), new Aluminum(1) };
        return elm;
    }

    public string toString() => "Cell Phone";
}   