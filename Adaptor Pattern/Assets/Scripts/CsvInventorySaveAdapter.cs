using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
public class CsvInventorySaveAdapter : ISaveAdapter
{
    public void SaveInventory(List<InventoryItem> inventoryItems, string filePath)
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Item Name,Item ID,Quantity");

        foreach (var item in inventoryItems)
        {
            stringBuilder.AppendLine($"{item.ItemName},{item.ItemID},{item.Quantity}");
        }

        File.WriteAllText(filePath, stringBuilder.ToString());
    }
}