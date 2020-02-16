using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copper : MonoBehaviour, Element
{
    public Color color = new Color(0.91f, 0.54f, 0.07f);

    private int count;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Copper;
    }

    public Copper(int c) => count = c;

    public string getDescription() => "Copper is the third most consumed industrial metal in the world, with 75% of it being used for wires, cables, and electronics.\nAtomic Number: 29  Atomic Mass: 63.546";

    public string getSymbol() => "Cu";

    public int getCount() => count;
}
