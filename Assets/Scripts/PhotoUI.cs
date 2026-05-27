using UnityEngine;
public class PhotoUI : MonoBehaviour
{
    public GameObject photoPanel;
    public void closePhotoPanel()
    {
        photoPanel.SetActive(false);
    }
}