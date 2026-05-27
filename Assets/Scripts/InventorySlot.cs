using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image itemImage;
    public GameObject highlight;

    public string itemID;
    public int slotIndex;

    private InventorySelectionManager selectionManager;

    void Start()
    {
        selectionManager = FindFirstObjectByType<InventorySelectionManager>();
        highlight.SetActive(false);
    }

    public void ClickSlot()
    {
        if (!itemImage.enabled || itemImage.sprite == null)
        {
            return;
        }

        selectionManager.SelectSlot(this);
    }

    public void SetSelected(bool selected)
    {
        highlight.SetActive(selected);
    }

    public bool IsKeyPart()
    {
        return itemID == "KeyPart1" || itemID == "KeyPart2";
    }

    public void ClearSlot()
    {
        itemImage.sprite = null;
        itemImage.enabled = false;
        itemID = "";
        SetSelected(false);
    }
}