using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanel : MonoBehaviour, Item
{
    public Color color = new Color(0.14f, 0.84f, 0.18f);

    private int count;
    public ControlPanel(int c) => count = c;

    private ItemType type;
    public ItemType getType()
    {
        return ItemType.ControlPanel;
    }

    public string getDescription() => "The Control Panel contains all the flashy buttons that go \"beep boop\".";

    public int getCount() => count;

    public Element[] getElements()
    {
        Element[] elm = { new Iron(5), new Aluminum(5), new Silicon(5), new Gold(2) };
        return elm;
    }
}