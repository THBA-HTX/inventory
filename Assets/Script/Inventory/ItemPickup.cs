using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPick : MonoBehaviour
{

    public float pickupRadius = 1.0f;
    public ItemData itemData;
    public BoxCollider2D collider2;
    // Start is called before the first frame update
    void Awake()
    {
        collider2 = GetComponent<BoxCollider2D>();
        collider2.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        var inventory = other.transform.GetComponent<InventoryHolder>();
        if (inventory == null)
            return;

        if (inventory.GetInventory().AddItem(itemData))
        {
            Destroy(this);
        }
    }
}
