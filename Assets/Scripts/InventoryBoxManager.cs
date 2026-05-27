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

                slot.preserveAspect = true;

                RectTransform slotRect = slot.GetComponent<RectTransform>();
                RectTransform parentRect = slot.transform.parent.GetComponent<RectTransform>();

                slotRect.sizeDelta = parentRect.rect.size;

                InventorySlot inventorySlot = slot.GetComponentInParent<InventorySlot>();
                inventorySlot.itemID = itemID;

                return true;
            }
        }

        return false;
    }
}