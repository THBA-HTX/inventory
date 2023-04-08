using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory { 

    public List<ItemData> itemList;

    public Inventory() {

        itemList = new List<ItemData>();

        itemList.Add( ScriptableObject.CreateInstance<ItemData>() ); 
        itemList.Add(ScriptableObject.CreateInstance<ItemData>()); 
        itemList.Add(ScriptableObject.CreateInstance<ItemData>()); 
        itemList.Add(ScriptableObject.CreateInstance<ItemData>()); 
        itemList.Add(ScriptableObject.CreateInstance<ItemData>()); 

        Debug.Log("Inventory: " + itemList.Count );
    }

    public bool AddItem(ItemData item) {
        Debug.Log("Item added to inventory..");
        itemList.Add(item);
        return true;
    
    }

    public List<ItemData> GetItemList() {
        return itemList;
    }

}
