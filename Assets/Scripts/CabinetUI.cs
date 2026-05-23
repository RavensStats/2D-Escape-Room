using UnityEngine;

public class CabinetUI : MonoBehaviour
{
    public GameObject cabinetPanel;
    public GameObject livingRoomPanel;

    public void makeCabinetBig()
    {
        cabinetPanel.SetActive(true);
        livingRoomPanel.SetActive(false);
    }
    public void makeCabinetSmall()
    {
        cabinetPanel.SetActive(false);
        livingRoomPanel.SetActive(true);
    }
}