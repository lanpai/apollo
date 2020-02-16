using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum ItemType
{
    Antenna = 0,
    BicycleMachine = 1,
    Book = 2,
    CellPhone = 3,
    Clothing = 4,
    ControlPanel = 5,
    Engine = 6,
    Flag = 7,
    FuelStorage = 8,
    InnerWall = 9,
    Laptop = 10,
    Mattress = 11,
    OuterWall = 12,
    Oven = 13,
    OxygenTank = 14,
    Pillow = 15,
    Radio = 16,
    Seats = 17,
    SelfDetonatingButton = 18,
    Server = 19,
    Toilet = 20,
    Utensil = 21,
    WaterBottle = 22,
    Window = 23
}
public interface Item
{
    ItemType getType();
    string getDescription();
    int getCount();   
}