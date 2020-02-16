using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothing : MonoBehaviour, Item
{
    public Color color = new Color(0.86f, 0.20f, 0.14f);

    private int count;
    public Clothing(int c) => count = c;

    public string getDescription() => "Dude. You're wearing clothes. How do you not know what clothing is. At least I hope you are.";

    public int getCount() => count;

    public Element[] getElement()
    {
        Element[] elm = { new Carbon(16), new Hydrogen(18), new Oxygen(9)};
        return elm;
    }
}