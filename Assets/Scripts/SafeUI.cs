using UnityEngine;

public class SafeUI : MonoBehaviour
{
    public GameObject safeSmall;
    public GameObject safePanel;
    public GameObject livingRoomPanel;
    public GameObject safeOpen;
    public GameObject drawerHandle;

    public void makeSafeBig()
    {
        safePanel.SetActive(true);
        livingRoomPanel.SetActive(false);
    }

    public void makeSafeSmall()
    {
        safePanel.SetActive(false);
        livingRoomPanel.SetActive(true);

    }

    public void openSafeBig()
    {
        safeOpen.SetActive(true);
        drawerHandle.SetActive(true);
    }
}