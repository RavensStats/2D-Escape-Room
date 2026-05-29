using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;

public class EndingSequence : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(EndGame());
    }

    IEnumerator EndGame() { 
        yield return new WaitForSeconds(20f);
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}