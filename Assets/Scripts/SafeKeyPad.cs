using UnityEngine;
using TMPro;

public class SafeKeypad : MonoBehaviour
{
    public GameObject openSafe;
    public GameObject showDrawerHandle;
    private string currentCode = "";
    public TMP_Text showCode;

    // The correct safe code
    public string correctCode = "1111";

    // Called when number buttons are pressed
    public void AddDigit(string digit)
    {
        currentCode += digit;
        showCode.text = currentCode;
    }

    // Called by the Clear button
    public void ClearCode()
    {
        currentCode = "";
        showCode.text = currentCode;
    }

    // Called by the # button
    public void SubmitCode()
    {
        if (currentCode == correctCode)
        {
            Debug.Log("SAFE OPENED!");

            openSafe.SetActive(true);
            showDrawerHandle.SetActive(true);
        }
        else
        {
            Debug.Log("WRONG CODE");
        }

        currentCode = "";
        showCode.text = currentCode;
    }

}