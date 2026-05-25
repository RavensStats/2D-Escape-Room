using UnityEngine;

public class InventorySelectionManager : MonoBehaviour
{
    private InventorySlot selectedSlot;

    public void SelectSlot(InventorySlot slot)
    {
        if (selectedSlot == slot)
        {
            selectedSlot.SetSelected(false);
            selectedSlot = null;
            return;
        }

        if (selectedSlot != null)
        {
            selectedSlot.SetSelected(false);
        }

        selectedSlot = slot;
        selectedSlot.SetSelected(true);
    }
}