using UnityEngine;

public class DoorUI: MonoBehaviour
{
    public GameObject door;
    public InventorySelectionManager inventorySelectionManager;

    public void OpenDoor()
    {
        if (door.activeSelf == true)    //door is already open, go through
            {
                //Switch scene or whatever 
            }
        if (inventorySelectionManager.GetSelectedItemID() == "key") //open door if key selected
        {
            door.SetActive(true);
            inventorySelectionManager.GetSelectedSlot().ClearSlot();
        }
    }
}