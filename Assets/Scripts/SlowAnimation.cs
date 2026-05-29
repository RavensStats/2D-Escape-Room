using UnityEngine;
using System.Collections;

public class SlowAnimation : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        StartCoroutine(SlowDown());
    }

    IEnumerator SlowDown()
    {
        float duration = 5f;
        float time = 0f;

        float startSpeed = 1f;
        float endSpeed = 0.5f;

        while (time < duration)
        {
            time += Time.deltaTime;

            animator.speed = Mathf.Lerp(
                startSpeed,
                endSpeed,
                time / duration
            );

            yield return null;
        }
    }
}