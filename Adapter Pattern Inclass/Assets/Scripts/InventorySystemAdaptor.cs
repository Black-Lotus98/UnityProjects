using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class InventorySystemAdaptor : InventorySystem, IInventorySystem
{
    private List<InventoryItem> cloudInventory;

    public void SyncInventories()
    {
        var cloudInventory = GetInventory();
        Debug.Log("Downloading the cloud inventory");
    }

    public void AddItem(InventoryItem anItem, SaveLocation aLocation)
    {
        if (aLocation == SaveLocation.Cloud)
        {
            AddItem(anItem);
        }

        if (aLocation == SaveLocation.Local)
        {
            Debug.Log("We need code here to save to the local drive");
        }

        if (aLocation == SaveLocation.Both)
        {
            AddItem(anItem);
            Debug.Log("We need code here to save to the local drive");
        }
    }

    public void RemoveItem(InventoryItem anItem, SaveLocation aLocation)
    {
        if (aLocation == SaveLocation.Cloud)
        {
            RemoveItem(anItem);
        }

        if (aLocation == SaveLocation.Local)
        {
            Debug.Log("We need code here to remove from the local drive");
        }

        if (aLocation == SaveLocation.Both)
        {
            RemoveItem(anItem);
            Debug.Log("We need code here to remove from the local drive");
        }
    }

    public List<InventoryItem> GetInventory(SaveLocation aLocation)
    {
        List<InventoryItem> inventory = new List<InventoryItem>();

        if (aLocation == SaveLocation.Cloud)
        {
            inventory = GetInventory();
        }

        if (aLocation == SaveLocation.Local)
        {
            Debug.Log("We need code here to get the inventory from the local drive");
        }

        if (aLocation == SaveLocation.Both)
        {
            inventory = GetInventory();
            Debug.Log("We need code here to get the inventory from the local drive");
        }

        return inventory;
        // return new List<InventoryItem>();
    }

    public void SaveInventoryToCSV(string filePath)
    {
        List<InventoryItem> inventory = GetInventory(SaveLocation.Both);
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Item Name,Description");
            foreach (InventoryItem item in inventory)
            {
                writer.WriteLine(item.ToCSV());
            }
        }
    }

}
