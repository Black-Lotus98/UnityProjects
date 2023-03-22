using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryItem
{
    [SerializeField] string itemName;
    [SerializeField] int quantity;
    [SerializeField] int itemID;

    public string ItemName { get { return this.itemName; } set { this.itemName = value; } }
    public int Quantity { get { return this.quantity; } set { this.quantity = value; } }
    public int ItemID { get { return this.itemID; } set { this.itemID = value; } }

    public InventoryItem(string anItemName, int aQuantity, int anItemID)
    {
        this.itemName = anItemName;
        this.quantity = aQuantity;
        this.itemID = anItemID;
    }
}
