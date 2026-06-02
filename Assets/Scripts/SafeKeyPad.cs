using UnityEngine;
using TMPro;

public class SafeKeypad : MonoBehaviour
{
    public GameObject openSafe;
    public GameObject showDrawerHandle;
    private string currentCode = "";
    public TMP_Text showCode;
    public AudioClip beep;
    public AudioClip doubleBeep;
    public AudioClip openSafeNoise;

    // The correct safe code
    public string correctCode = "300483";

    // Called when number buttons are pressed
    public void AddDigit(string digit)
    {
        SoundManager.Instance.PlaySound(beep);
        if (showCode.text.Length < 6)
        {
            currentCode += digit;
            showCode.text = currentCode;
        }
    }

    // Called by the Clear button
    public void ClearCode()
    {
        SoundManager.Instance.PlaySound(beep);
        currentCode = "";
        showCode.text = currentCode;
    }

    // Called by the # button
    public void SubmitCode()
    {
        if (currentCode == correctCode)
        {
            SoundManager.Instance.PlaySound(openSafeNoise);
            Debug.Log("SAFE OPENED!");

            openSafe.SetActive(true);
            showDrawerHandle.SetActive(true);
        }
        else
        {
            Debug.Log("WRONG CODE");
            SoundManager.Instance.PlaySound(doubleBeep);
        }

        currentCode = "";
        showCode.text = currentCode;
    }

}