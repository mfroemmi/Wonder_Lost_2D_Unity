using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int AppleQuantity { get; private set; }
    public int WoodQuantity { get; private set; }

    public void AppleCollected()
    {
        AppleQuantity++;
    }

    public void WoodCollected()
    {
        WoodQuantity++;
    }
}
