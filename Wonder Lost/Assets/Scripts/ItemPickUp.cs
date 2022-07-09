using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.TryGetComponent<ItemObject>(out ItemObject item);
        item.OnHandlePickupItem();
    }
}
