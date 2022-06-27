using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingMaterial : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerInventory playerInventory = collision.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            if (gameObject.CompareTag("Wood")){
                playerInventory.WoodCollected();
                gameObject.SetActive(false);
            }
        }
    }
}
