using UnityEngine;
public class LampUI : MonoBehaviour
{
    public GameObject lightbulb;
    public GameObject UVSymbols;
    public GameObject UVSymbolLamp;
    public InventorySelectionManager inventorySelectionManager;
    public GameObject UVLighting;
    public void SlotLightbulb()
    {
        if (inventorySelectionManager.GetSelectedItemID() == "Lightbulb")
        {
            lightbulb.SetActive(true);
            UVSymbolLamp.SetActive(true);
            UVSymbols.SetActive(true);
            inventorySelectionManager.GetSelectedSlot().ClearSlot();
            UVLighting.SetActive(true);
        }
    }
}