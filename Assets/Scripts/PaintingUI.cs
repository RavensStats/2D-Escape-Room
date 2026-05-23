using UnityEngine;

public class PaintingUI : MonoBehaviour
{
    public GameObject paintingClosed;
    public GameObject paintingOpen;
    public GameObject safeSmall;

    public void PaintingSafe()
    {
        paintingClosed.SetActive(false);
        paintingOpen.SetActive(true);
        safeSmall.SetActive(true);
    }
}