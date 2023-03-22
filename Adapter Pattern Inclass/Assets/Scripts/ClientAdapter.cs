using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class ClientAdapter : MonoBehaviour
{
    public InventoryItem item;

    private InventorySystem inventorySystem;
    private IInventorySystem inventorySystemAdaptor;


    // Start is called before the first frame update
    void Start()
    {
        inventorySystem = new InventorySystem();
        inventorySystemAdaptor = new InventorySystemAdaptor();
    }

    // Update is called once per frame
    void OnGUI()
    {
        if (GUILayout.Button("Add item (no adaptor)"))
        {
            inventorySystem.AddItem(item);
        }

        if (GUILayout.Button("Add item (with adaptor)"))
        {
            inventorySystemAdaptor.AddItem(item, SaveLocation.Both);
        }

        if (GUILayout.Button("Save inventory to CSV"))
        {
            string filePath = Path.Combine(Application.dataPath, "inventory.csv");
            Debug.Log($"{filePath}");
            inventorySystemAdaptor.SaveInventoryToCSV(filePath);
        }
    }
}
