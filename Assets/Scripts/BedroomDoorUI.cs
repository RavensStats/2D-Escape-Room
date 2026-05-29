using UnityEngine;
using UnityEngine.SceneManagement;

public class BedroomDoorUI : MonoBehaviour
{
    public void ExitRoom()
    {

        Debug.Log("Exiting");
        SceneManager.LoadScene("LivingroomScene");
    }
}