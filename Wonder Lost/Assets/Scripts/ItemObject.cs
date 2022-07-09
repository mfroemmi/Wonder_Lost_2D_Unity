using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public InventoryItemData referenceItem;
    public InventorySystem inventorySystem;

    public void OnHandlePickupItem()
    {
        inventorySystem.Add(referenceItem);
        Destroy(gameObject);
    }
}
