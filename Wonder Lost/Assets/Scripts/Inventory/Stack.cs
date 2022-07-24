using UnityEngine;
using UnityEngine.UI;

public class Stack : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Text label;
    [SerializeField] private GameObject stackObject;
    [SerializeField] private Text stackLabel;

    public void Set(InventoryItem item)
    {
        icon.sprite = item.data.icon;
        label.text = item.data.displayName;

        if(item.stackSize <= 1)
        {
            stackObject.SetActive(false);
            return;
        }
        stackLabel.text = item.stackSize.ToString();
    }
}
