using UnityEngine;

public class DrawerUI : MonoBehaviour
{
    public GameObject drawerPanel;
    public GameObject livingRoomPanel;
    public GameObject dollClosed;
    public GameObject dollOpenHead;
    public GameObject dollOpenBody;

    public void MakeDrawerBig()
    {
        drawerPanel.SetActive(true);
        livingRoomPanel.SetActive(false);
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