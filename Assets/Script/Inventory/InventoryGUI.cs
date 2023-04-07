using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGUI : MonoBehaviour
{

    private Inventory inventory;
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;


    public void Awake()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");
    }

    public void SetInventory(Inventory inv) {
        inventory = inv;
        RefreshInventoryItems();
    }
    
    
    public void RefreshInventoryItems() {
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 20f;
        int numColumns = 4;
        //int numRows = 2;

        foreach (var item in inventory.GetItemList())
        { 
            Instantiate(itemSlotTemplate, itemSlotContainer);
        
            //Object obj = Instantiate(itemSlotTemplate, itemSlotContainer);
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);

            Image image = itemSlotRectTransform.Find("image").GetComponent<Image>();
            image.sprite = item.icon;

            x++;
            if (x > numColumns) {
                x = 0;
                y++;
            }
        }
    
    }
}
