using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "new Item", menuName = "Inventory")]

public class InventoryItem : ScriptableObject
{
    // placeholder class you will need to flesh this out for your assignment
    //you can change it to a monster, or npc, or anything in your game you want
    //
    public string itemName;
    public string description;
    public string ToCSV()
    {
        return string.Format("{0},{1}", itemName, description);
    }

    public enum ItemType
    {
        Weapon,
        Armor,
        Consumable,
        QuestItem
    }
}
