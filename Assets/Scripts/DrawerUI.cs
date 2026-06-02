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
    public AudioClip drawerNoise;
    public AudioClip drawerLockedNoise;
    public AudioClip drawerHandleNoise;

    public void MakeDrawerBig()
    {
        if (drawerHandle.activeSelf)
        {
            SoundManager.Instance.PlaySound(drawerNoise);
            drawerPanel.SetActive(true);
            livingRoomPanel.SetActive(false);
        }
        if (inventorySelectionManager.GetSelectedItemID() == "Drawer_Handle")
        {
            drawerHandle.SetActive(true);
            inventorySelectionManager.GetSelectedSlot().ClearSlot();
            SoundManager.Instance.PlaySound(drawerHandleNoise);

        }
        if (!drawerHandle.activeSelf)
        {
            messageController.ShowMessage("The drawer is locked.");
            SoundManager.Instance.PlaySound(drawerLockedNoise);
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