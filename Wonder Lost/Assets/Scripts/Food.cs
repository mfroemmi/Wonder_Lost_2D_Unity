using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerInventory playerInventory = collision.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.AppleCollected();
            gameObject.SetActive(false);
        }
    }

}
