using UnityEngine;
using UnityEngine.UI;

public class InventoryBoxManager : MonoBehaviour
{
    public Image[] slots;

    public bool AddItem(Sprite itemIcon)
    {
        foreach (Image slot in slots)
        {
            if (!slot.enabled)
            {
                slot.sprite = itemIcon;
                slot.enabled = true;

                slot.SetNativeSize();

                return true;
            }
        }

        Debug.Log("Inventory full");
        return false;
    }
}
