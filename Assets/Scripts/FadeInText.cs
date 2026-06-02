using System.Collections;
using TMPro;
using UnityEngine;

public class FadeInText : MonoBehaviour
{
    public TextMeshProUGUI textObject;
    public float delay = 5f;
    public float fadeDuration = 2f;

    private void Start()
    {
        Color color = textObject.color;
        color.a = 0f;
        textObject.color = color;

        StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(delay);

        float elapsed = 0f;
        Color color = textObject.color;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            color.a = Mathf.Clamp01(elapsed / fadeDuration);
            textObject.color = color;
            yield return null;
        }

        color.a = 1f;
        textObject.color = color;
    }
}