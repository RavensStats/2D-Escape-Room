using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public InventoryBoxManager inventoryManager;
    public Sprite inventoryIcon;

    public void PickUpItem()
    {
        bool added = inventoryManager.AddItem(inventoryIcon);

        if (added)
        {
            gameObject.SetActive(false);
        }
    }
}
