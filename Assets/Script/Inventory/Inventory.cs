using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory { 

    public List<ItemData> itemList;

    public Inventory() {

        itemList = new List<ItemData>();

        Debug.Log("Inventory: " + itemList.Count );
    }

    public bool AddItem(ItemData item) {
        itemList.Add(item);
        return true;
    
    }

    public List<ItemData> GetItemList() {
        return itemList;
    }

}
