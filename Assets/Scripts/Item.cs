using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Inventory system/Inventory item")]
public class Item : ScriptableObject
{

    public new string name;
    [TextArea (4,4)]
    public string description;

    public Sprite itemIcon;

    public ItemType itemType;
    public decimal? price;
    public int amount;
    public int maxStack;
    public bool canExpire;
    public System.DateTime expirationDate;

    
}

 public enum ItemType
{
    DEFAULT,
    STACKABLE,
    NON_STACKABLE
}
