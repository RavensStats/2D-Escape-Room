using UnityEngine;

public class SliderUI : MonoBehaviour
{
    public GameObject BedroomPanel;
    public GameObject SliderPanel;

    public void OpenSliderPanel()
    {
        BedroomPanel.SetActive(false);
        SliderPanel.SetActive(true);
    }

    public void CloseSliderPanel()
    {
        BedroomPanel.SetActive(true);
        SliderPanel.SetActive(false);
    }
}