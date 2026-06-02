using UnityEngine;

public class PaintingUI : MonoBehaviour
{
    public GameObject paintingClosed;
    public GameObject paintingOpen;
    public GameObject safeSmall;

    public void OpenPainting()
    {
        paintingClosed.SetActive(false);
        paintingOpen.SetActive(true);
        safeSmall.SetActive(true);
    }
    
    public void ClosePainting()
    {
        paintingClosed.SetActive(true);
        paintingOpen.SetActive(false);
        safeSmall.SetActive(false);
    }
}