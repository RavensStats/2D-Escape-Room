using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public InventoryBoxManager inventoryManager;
    public Sprite inventoryIcon;
    public string itemID;

    public void PickUpItem()
    {
        bool added = inventoryManager.AddItem(inventoryIcon, itemID);

        if (added)
        {
            gameObject.SetActive(false);
        }
    }
}