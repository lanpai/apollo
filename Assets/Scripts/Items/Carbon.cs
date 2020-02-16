using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carbon : MonoBehaviour, Element
{
    public Color color = new Color(0.23f, 0.23f, 0.23f);

    private int count;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Carbon;
    }

    public Carbon(int c) => count = c;

    public string getDescription() => "Carbon is the biological building block of all life.\nAtomic Number: 6  Atomic Mass: 12.011";

    public int getCount() => count;

    public string toString() => "C";
}
