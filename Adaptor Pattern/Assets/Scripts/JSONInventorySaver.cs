using System.Collections.Generic;
using System.IO;

public class JSONInventorySaver : ISaveAdapter
{
    public void SaveInventory(List<InventoryItem> inventoryItems, string filePath)
    {
        string json = JsonHelper.ToJson(inventoryItems.ToArray(), true);
        File.WriteAllText(filePath, json);
    }
}
