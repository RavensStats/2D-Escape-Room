using UnityEngine;
using UnityEngine.InputSystem;

public class InteractWithEnvironment : MonoBehaviour
{
    [SerializeField] private LayerMask clickableLayer;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            Debug.Log($"Mouse clicked at world position: {mousePosition}");

            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero, 0f, clickableLayer);

            if(hit.collider != null)
            {
                Debug.Log($"Hit collider: {hit.collider.name}");
                var clickable = hit.collider.GetComponent<ClickableTarget>();
                if (clickable != null)
                {
                    clickable.HandleClick();
                }
                else
                {
                    Debug.Log("No ClickableTarget script found on hit object.");
                }
            }
            else
            {
                Debug.Log("No collider hit.");
            }
        }
    }
}