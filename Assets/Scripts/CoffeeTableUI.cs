using UnityEngine;
public class CoffeeTableUI : MonoBehaviour
{
    public GameObject DrawerToOpen;
    public GameObject DrawerToClose;
    public GameObject LivingRoomPanel;

    public void OpenDrawer()
    {
        DrawerToOpen.SetActive(true);
        LivingRoomPanel.SetActive(false);
    }
    public void CloseDrawer()
    {
        DrawerToClose.SetActive(false);
        LivingRoomPanel.SetActive(true);
    }

    
}