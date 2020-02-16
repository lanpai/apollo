using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silicon : MonoBehaviour, Element
{
    public Color color = new Color(0.91f, 0.54f, 0.07f);

    private int count;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Copper;
    }

    public Silicon(int c) => count = c;

    public string getDescription() => "Silicon is used in transistors, one of the most important advancements to humankind's ability to process the world around them.";

    public string toString() => "Si";

    public int getCount() => count;
}
