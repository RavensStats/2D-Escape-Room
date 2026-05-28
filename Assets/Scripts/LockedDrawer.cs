using UnityEngine;

public class LockedDrawer : MonoBehaviour
{
    public InventorySelectionManager inventorySelectionManager;

    public GameObject closedDrawer;
    public GameObject openedDrawer;
    public GameObject topDrawerButton;

    public MessageController messageController;

    public void ClickDrawer()
    {
        if (inventorySelectionManager.GetSelectedItemID() == "WholeKey")
        {
            InventorySlot usedSlot =
                inventorySelectionManager.GetSelectedSlot();

            usedSlot.ClearSlot();

            closedDrawer.SetActive(false);
            openedDrawer.SetActive(true);
            topDrawerButton.SetActive(false);
        }
        else
        {
            messageController.ShowMessage("The drawer is locked.");
        }
    }
}