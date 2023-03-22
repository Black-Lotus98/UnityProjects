using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<InventoryItem> inventoryItems;
    private ISaveAdapter inventorySaver;

    private void Start()
    {
        inventoryItems = new List<InventoryItem>
        {
            new InventoryItem("Sword", 1, 5),
            new InventoryItem("Shield", 2, 2),
            new InventoryItem("Potion", 3, 10)
        };

        string dataPath = Application.persistentDataPath;

        // Save as CSV
        inventorySaver = new CsvInventorySaveAdapter();
        inventorySaver.SaveInventory(inventoryItems, $"{dataPath}/InventoryItems.csv");
        Debug.Log($"{dataPath}/InventoryItems.csv");
        Debug.Log($"{dataPath}/InventoryItems.json");
        // Save as JSON

        inventorySaver = new JSONInventorySaver();
        inventorySaver.SaveInventory(inventoryItems, $"{dataPath}/InventoryItems.json");
    }
}