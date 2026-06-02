using UnityEngine;
public class LampUI : MonoBehaviour
{
    public GameObject lightbulb;
    public GameObject UVSymbols;
    public GameObject UVSymbolLamp;
    public InventorySelectionManager inventorySelectionManager;
    public GameObject UVLighting;
    public AudioClip lightAudio;
    public void SlotLightbulb()
    {
        if (inventorySelectionManager.GetSelectedItemID() == "Lightbulb")
        {
            SoundManager.Instance.PlaySound(lightAudio);
            lightbulb.SetActive(true);
            UVSymbolLamp.SetActive(true);
            UVSymbols.SetActive(true);
            inventorySelectionManager.GetSelectedSlot().ClearSlot();
            UVLighting.SetActive(true);
        }
    }
}