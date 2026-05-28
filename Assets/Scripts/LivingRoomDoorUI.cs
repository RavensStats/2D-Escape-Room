using UnityEngine;

public class LivingRoomDoorUI: MonoBehaviour
{
    public GameObject door;
    public InventorySelectionManager inventorySelectionManager;
    public MessageController messageController;

    public void OpenDoor()
    {
        if (door.activeSelf == true)    //door is already open, go through
            {
                //Switch scene or whatever 
            }
        else
        {
            if (inventorySelectionManager.GetSelectedItemID() == "key") //open door if key selected
            {
                door.SetActive(true);
                inventorySelectionManager.GetSelectedSlot().ClearSlot();
            }
            else
            {
                messageController.ShowMessage("The door is locked.");

            }
        }
            
    }
}