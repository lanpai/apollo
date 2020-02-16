using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aluminum : MonoBehaviour, Element
{
    public Color color = new Color(.8f,.8f,.8f);

    private int count;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Aluminum;
    }

    public Aluminum(int c) => count = c;

    public string getDescription() => "Aluminum is a main component of aircraft and spacecraft due to its durability, low weight, and heat-resistance.\nAtomic Number: 13  Atomic Mass: 26.982";

    public string getSymbol() => "Al";

    public int getCount() => count;

    public string toString() => "Aluminum";
}
