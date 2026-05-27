using UnityEngine;
using UnityEngine.UI;

public class InventoryBoxManager : MonoBehaviour
{
    public Image[] slots;

    public bool AddItem(Sprite itemIcon, string itemID)
    {
        foreach (Image slot in slots)
        {
            if (!slot.enabled)
            {
                slot.sprite = itemIcon;
                slot.enabled = true;
                slot.SetNativeSize();

                InventorySlot inventorySlot = slot.GetComponentInParent<InventorySlot>();
                inventorySlot.itemID = itemID;

                return true;
            }
        }

        return false;
    }
}