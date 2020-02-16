using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server : Item
{
    private int count;
    public Server(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "";
    }

    public int getCount()
    {
        return count;
    }
}