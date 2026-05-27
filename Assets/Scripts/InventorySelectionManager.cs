using UnityEngine;

public class InventorySelectionManager : MonoBehaviour
{
    private InventorySlot selectedSlot;
    private InventorySlot selectedKeyPart1;
    private InventorySlot selectedKeyPart2;

    public GameObject combineButton;
    public Sprite wholeKeyIcon;

    public void SelectSlot(InventorySlot slot)
    {
        // Clicking selected normal item again unselects it
        if (selectedSlot == slot)
        {
            selectedSlot.SetSelected(false);
            selectedSlot = null;
            combineButton.SetActive(false);
            return;
        }

        // Key parts special case
        if (slot.IsKeyPart())
        {
            SelectKeyPart(slot);
            return;
        }

        // Normal item: unselect everything else
        ClearAllSelections();

        selectedSlot = slot;
        selectedSlot.SetSelected(true);
        combineButton.SetActive(false);
    }

    private void SelectKeyPart(InventorySlot slot)
    {
        selectedSlot = null;

        if (slot.itemID == "KeyPart1")
        {
            if (selectedKeyPart1 == slot)
            {
                selectedKeyPart1.SetSelected(false);
                selectedKeyPart1 = null;
            }
            else
            {
                selectedKeyPart1 = slot;
                selectedKeyPart1.SetSelected(true);
            }
        }

        if (slot.itemID == "KeyPart2")
        {
            if (selectedKeyPart2 == slot)
            {
                selectedKeyPart2.SetSelected(false);
                selectedKeyPart2 = null;
            }
            else
            {
                selectedKeyPart2 = slot;
                selectedKeyPart2.SetSelected(true);
            }
        }

        combineButton.SetActive(selectedKeyPart1 != null && selectedKeyPart2 != null);
    }

    private void ClearAllSelections()
    {
        if (selectedSlot != null)
            selectedSlot.SetSelected(false);

        if (selectedKeyPart1 != null)
            selectedKeyPart1.SetSelected(false);

        if (selectedKeyPart2 != null)
            selectedKeyPart2.SetSelected(false);

        selectedSlot = null;
        selectedKeyPart1 = null;
        selectedKeyPart2 = null;
    }

    public void CombineKeyParts()
    {
        if (selectedKeyPart1 == null || selectedKeyPart2 == null)
            return;

        InventorySlot targetSlot;

        if (selectedKeyPart1.slotIndex < selectedKeyPart2.slotIndex)
            targetSlot = selectedKeyPart1;
        else
            targetSlot = selectedKeyPart2;

        selectedKeyPart1.ClearSlot();
        selectedKeyPart2.ClearSlot();

        targetSlot.itemImage.sprite = wholeKeyIcon;
        targetSlot.itemImage.enabled = true;
        targetSlot.itemImage.SetNativeSize();
        targetSlot.itemID = "WholeKey";

        targetSlot.SetSelected(false);

        selectedKeyPart1 = null;
        selectedKeyPart2 = null;

        combineButton.SetActive(false);
    }

    public string GetSelectedItemID()
    {
        if (selectedSlot != null)
        {
            return selectedSlot.itemID;
        }

        return "";
    }

    public InventorySlot GetSelectedSlot()
    {
        return selectedSlot;
    }
}
