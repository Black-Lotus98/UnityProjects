using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem
{

    private List<InventoryItem> items;

    public InventorySystem()
    {
        items = new List<InventoryItem>();
    }

    public void AddItem(InventoryItem anItem)
    {
        items.Add(anItem);
        Debug.Log("Adding item to the cloud");
    }

    public void RemoveItem(InventoryItem anItem)
    {
        items.Remove(anItem);
        Debug.Log("Removing item from the cloud");
    }

    public List<InventoryItem> GetInventory()
    {
        Debug.Log("Getting items from the cloud");
        return items;
    }
}
