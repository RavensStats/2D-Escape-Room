using UnityEngine;

public class DrawerUI : MonoBehaviour
{
    public InventorySelectionManager inventorySelectionManager;
    public MessageController messageController;
    public GameObject drawerPanel;
    public GameObject livingRoomPanel;
    public GameObject drawerHandle;
    public GameObject dollClosed;
    public GameObject dollOpenHead;
    public GameObject dollOpenBody;

    public void MakeDrawerBig()
    {
        if (drawerHandle.activeSelf)
        {
            drawerPanel.SetActive(true);
            livingRoomPanel.SetActive(false);
        }
        if (inventorySelectionManager.GetSelectedItemID() == "Drawer_Handle")
        {
            drawerHandle.SetActive(true);
            inventorySelectionManager.GetSelectedSlot().ClearSlot();

        }
        else
        {
            //messageController.ShowMessage("The drawer is locked");
        }
    }

    
    
    public void MakeDrawerSmall()
    {
        drawerPanel.SetActive(false);
        livingRoomPanel.SetActive(true);    
    }

    public void OpenDoll()
    {
        dollClosed.SetActive(false);
        dollOpenBody.SetActive(true);
        dollOpenHead.SetActive(true);
    }
}