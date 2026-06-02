using UnityEngine;
using UnityEngine.SceneManagement;

public class LivingRoomDoorUI: MonoBehaviour
{
    public GameObject door;
    public InventorySelectionManager inventorySelectionManager;
    public MessageController messageController;
    public AudioClip unlockAudio;

    public void OpenDoor()
    {
        if (door.activeSelf == true)    //door is already open, go through
            {
                SceneManager.LoadScene("EndingScene");
            }
        else
        {
            if (inventorySelectionManager.GetSelectedItemID() == "key") //open door if key selected
            {
                SoundManager.Instance.PlaySound(unlockAudio);
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