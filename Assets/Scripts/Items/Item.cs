using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Item
{
    public string Description { get; }
    public int Count { get; set; }
}
