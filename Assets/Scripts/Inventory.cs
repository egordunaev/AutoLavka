using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private decimal? balance;
    private Item[] items;
    private InventoryType inventoryType;
    private int maxInventorySlots;
    
}
enum InventoryType
{
    DEFAULT,
    COOLED
}
