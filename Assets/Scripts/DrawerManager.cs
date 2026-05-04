using UnityEngine;

public class DrawerManager : MonoBehaviour
{
    public GameObject[] closedDrawers;

    public GameObject[] openDrawers;

    public void OpenOnly(GameObject drawerToOpen)
    {
        foreach (GameObject drawer in openDrawers)
        {
            drawer.SetActive(drawer == drawerToOpen);
        }
    }

    public void DisableOnly(GameObject drawerToDisable)
    {
        foreach (GameObject drawer in closedDrawers)
        {
            drawer.SetActive(drawer != drawerToDisable);
        }
    }
}