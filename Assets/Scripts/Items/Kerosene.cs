using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kerosenek : MonoBehaviour, Item
{
    public Color color = new Color(00.65f, 0.85f, 1f);
    private int count;

    public Kerosene(int c) => count = c;

    public string getDescription() => "The main propulsion of the Helios spacecraft.";

    public int getCount() => count;

    public Element[] getElements()
    {
        Element[] elm = { new Carbon(10), new Hydrogen(22)};
        return elm;
    }
}