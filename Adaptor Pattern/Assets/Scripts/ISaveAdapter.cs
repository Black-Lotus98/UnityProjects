using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISaveAdapter 
{
    void SaveInventory(List<InventoryItem> inventoryItems, string filePath);
}