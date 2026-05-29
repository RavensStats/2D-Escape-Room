using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class FadeImage : MonoBehaviour
{
    public SpriteRenderer image;

    void Start()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(5f);
        float duration = 10f;
        float time = 0f;

        Color startColor = image.color;

        while (time < duration)
        {
            time += Time.deltaTime;

            float alpha = Mathf.Lerp(1f, 0f, time / duration);

            image.color = new Color(
                startColor.r,
                startColor.g,
                startColor.b,
                alpha
            );

            yield return null;
        }
    }
}