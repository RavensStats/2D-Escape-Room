using UnityEngine;
using TMPro;
using System.Collections;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject messageBox;
    public TMP_Text messageText;

    Coroutine currentCoroutine;

    public void ShowMessage(string text)
    {
        messageBox.SetActive(true);
        messageText.text = text;

        if (currentCoroutine != null)
            StopCoroutine(currentCoroutine);

        currentCoroutine = StartCoroutine(HideMessageAfterTime(2f));
    }

    IEnumerator HideMessageAfterTime(float delay)
    {
        yield return new WaitForSeconds(delay);
        messageBox.SetActive(false);
    }
}
