using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumberofApples { get; private set; }

    public void AppleCollected()
    {
        NumberofApples++;
    }
}
