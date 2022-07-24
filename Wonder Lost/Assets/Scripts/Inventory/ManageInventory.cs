using System;
using UnityEngine;

public class ManageInventory : MonoBehaviour
{
    [SerializeField] private GameObject slotPrefab;
    public void Start()
    {
        InventorySystem.current.onInventoryChangeEvent += OnUpdateInventory;
    }

    private void OnUpdateInventory()
    {
        foreach(Transform t in transform)
        {
            Destroy(t.gameObject);
        }

        DrawInventory();
    }

    public void DrawInventory()
    {
        foreach(InventoryItem item in InventorySystem.current.inventory)
        {
            AddInventorySlot(item);
        }
    }
    public void AddInventorySlot(InventoryItem item)
    {
        GameObject obj = Instantiate(slotPrefab);
        obj.transform.SetParent(transform, false);
        Debug.Log(obj.transform.position);
        Stack slot = obj.GetComponent<Stack>();
        slot.Set(item);
    }
}
