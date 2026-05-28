using UnityEngine;
public class LampUI : MonoBehaviour
{
    public GameObject lightbulb;
    public GameObject UVSymbols;
    public GameObject UVSymbolLamp;
    public InventorySelectionManager inventorySelectionManager;
    public void SlotLightbulb()
    {
        if (inventorySelectionManager.GetSelectedItemID() == "Lightbulb")
        {
            lightbulb.SetActive(true);
            UVSymbolLamp.SetActive(true);
            UVSymbols.SetActive(true);
            inventorySelectionManager.GetSelectedSlot().ClearSlot();
        }
    }
}