using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Antenna,
    BicycleMachine,
    Book,
    CellPhone,
    Clothing,
    ControlPanel,
    Engine,
    Flag,
    FuelStorage,
    InnerWall,
    Laptop,
    Mattress,
    OuterWall,
    Oven,
    OxygenTank,
    Pillow,
    Radio,
    Seats,
    SelfDetonatingButton,
    Server,
    Toilet,
    Utensil,
    WaterBottle,
    Window,
    Kerosene,
    LiquidOx,
    Aluminum,
    Carbon,
    Copper,
    Germanium,
    Gold,
    Hydrogen,
    Iron,
    Lithium,
    Nickel,
    Nitrogen,
    Oxygen,
    Silicon,
    Silver,
    Tin,
    Titanium
}
public interface Item
{
    ItemType getType();
    string getDescription();
    int getCount();   
}