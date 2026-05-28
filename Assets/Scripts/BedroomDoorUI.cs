using UnityEngine;

public class BedroomDoorUI : MonoBehaviour
{
    public GameObject door;
    public MessageController messageController;

    public void OpenDoor()
    {
        if (door.activeSelf == true)
        {
            //go through door
        }
        else
        {
            messageController.ShowMessage("The door is locked.");
        }
    }
}