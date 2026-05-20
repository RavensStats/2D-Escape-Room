using UnityEngine;

public class InventoryBoxManager : MonoBehaviour
{
    public void ChangeState(GameObject box)
    {
        box.SetActive(!box.activeSelf);
        return;
    }
}
