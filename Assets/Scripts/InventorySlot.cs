using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image itemImage;
    public GameObject highlight;

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
}