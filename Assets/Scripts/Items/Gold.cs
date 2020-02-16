using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour, Element
{
    Color color = new Color(0.98f, 0.66f, 0.04f);
    private int count;

    public Gold(int c)
    {
        count = c;
    }

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Gold;
    }

    public string getDescription()
    {
        return "Fun Fact: If you bite gold, you might break your teeth!\nAtomic Number: 79  Atomic Mass: 196.97";
    }

    public string getSymbol()
    {
        return "Au";
    }

    public int getCount()
    {
        return count;
    }
}
