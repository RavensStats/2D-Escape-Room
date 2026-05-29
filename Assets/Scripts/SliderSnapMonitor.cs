using UnityEngine;

public class SliderSnapMonitor : MonoBehaviour
{
    public UISliderSnap[] sliders; // Assign all UISliderSnap components in the Inspector
    public GameObject[] objectsToActivate; // Assign 4 GameObjects to activate
    public GameObject BedroomPanel;
    public GameObject SliderPanel;
    public GameObject DoorOpen;
    private int[] lastSnapIndices;
    private bool activated = false;
    public MessageController messageController;
    private bool DoorOpened;

    void Start()
    {
        if (sliders == null || sliders.Length == 0)
        {
            Debug.LogWarning("No sliders assigned to SliderSnapMonitor.");
            return;
        }
        lastSnapIndices = new int[sliders.Length];
        for (int i = 0; i < sliders.Length; i++)
        {
            lastSnapIndices[i] = sliders[i].GetCurrentSnapIndex();
        }
        DoorOpened = false;
    }

    void Update()
    {
        if (!DoorOpened) {
            for (int i = 0; i < sliders.Length; i++)
            {
                int currentIndex = sliders[i].GetCurrentSnapIndex();
                if (currentIndex != lastSnapIndices[i])
                {
                    Debug.Log($"Slider {i + 1} snap index changed: {lastSnapIndices[i]} -> {currentIndex}");
                    lastSnapIndices[i] = currentIndex;
                }
            }

            // Check for the specific combination
            bool match = sliders.Length >= 4 &&
                sliders[0].GetCurrentSnapIndex() == 0 &&
                sliders[1].GetCurrentSnapIndex() == 1 &&
                sliders[2].GetCurrentSnapIndex() == 3 &&
                sliders[3].GetCurrentSnapIndex() == 2;

            if (match && !activated)
            {
                Debug.Log("Sliders Correct");
                foreach (var obj in objectsToActivate)
                {
                    if (obj != null)
                    {
                        obj.SetActive(true);
                        Debug.Log($"Activated: {obj.name}");
                    }
                }
                activated = true;
                DoorOpened = true;
                DoorOpen.SetActive(true);
                messageController.ShowMessage("You hear a click.");
                
            }
            else if (!match && activated)
            {
                foreach (var obj in objectsToActivate)
                {
                    if (obj != null)
                    {
                        obj.SetActive(false);
                        Debug.Log($"Deactivated: {obj.name}");
                    }
                }
                activated = false;
            }
        }
    }
}
