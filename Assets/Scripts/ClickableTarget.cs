using UnityEngine;

public class ClickableTarget : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToActivate;
    [SerializeField] private GameObject[] objectsToDeactivate;

    public void HandleClick()
    {
        foreach (var obj in objectsToActivate)
        {
            if (obj != null)
            {
                obj.SetActive(true);
                Debug.Log($"Activated: {obj.name}");
            }
        }
        foreach (var obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
                Debug.Log($"Deactivated: {obj.name}");
            }
        }
    }
}
