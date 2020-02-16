using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server : MonoBehaviour, Item
{
    private int count;
    public Server(int c)
    {
        count = c;
    }
    private ItemType type;
    public ItemType getType()
    {
        return ItemType.Server;
    }

    public string getDescription()
    {
        return "It lets you communicate with SpaceEX. Destroying it would be big bad.";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Carbon(1), new Hydrogen(1)};
        return elm;
    }
}