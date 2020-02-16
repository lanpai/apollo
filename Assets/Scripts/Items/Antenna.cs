using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antenna : MonoBehaviour, Item
{
    public Color color = new Color(0.35f, 0.29f, 0.29f);

    private int count;
    public Antenna(int c) => count = c;

    public string getDescription() => "Antennae are used tozzzzz- $$$%%% -nd recieeeee$$$ zz~~~ Hmmm. Reception seems to be terrible.";

    public int getCount() => count;

    public Element[] getElements()
    {
        Element[] elm = { new Iron(3) };
        return elm;
    }
}