using UnityEngine;
using TMPro;

public class CoffeeTableKeyPad : MonoBehaviour
{
    public GameObject openDrawer;
    public GameObject showKey;
    public GameObject livingRoomPanel;
    public GameObject coffeeTableRightPanel;
    public GameObject coffeeTableLeftPanel;
    public GameObject closedDrawer;
    public GameObject leftButton;
    public GameObject rightButton;
    public MessageController messageControllerRight;
    public MessageController messageControllerLeft;

    public TMP_Text[] leftButtons;
    public TMP_Text[] rightButtons;

    public string correctCode1 = "24315";
    public string correctCode2 = "42189";

    void UpdateCode(string side, int index)
    {
        TMP_Text targetText;

        if (side == "left")
        {
            targetText = leftButtons[index];
        }
        else
        {
            targetText = rightButtons[index];
        }

        int number = int.Parse(targetText.text);

        number = (number + 1) % 10;

        targetText.text = number.ToString();

        CheckCodes(side);
    }

    // LEFT BUTTONS
    public void Left0() { UpdateCode("left", 0); }
    public void Left1() { UpdateCode("left", 1); }
    public void Left2() { UpdateCode("left", 2); }
    public void Left3() { UpdateCode("left", 3); }
    public void Left4() { UpdateCode("left", 4); }

    // RIGHT BUTTONS
    public void Right0() { UpdateCode("right", 0); }
    public void Right1() { UpdateCode("right", 1); }
    public void Right2() { UpdateCode("right", 2); }
    public void Right3() { UpdateCode("right", 3); }
    public void Right4() { UpdateCode("right", 4); }

    void CheckCodes(string side)
    {
        string leftCode = "";
        string rightCode = "";

        foreach (TMP_Text t in leftButtons)
        {
            leftCode += t.text;
        }

        foreach (TMP_Text t in rightButtons)
        {
            rightCode += t.text;
        }
        if ((leftCode == correctCode1 &&
            rightCode == correctCode2) ||
            (leftCode == correctCode2 &&
            rightCode == correctCode1))
        {
            Debug.Log("Drawer Opened!");
            if (side == "right") {
                messageControllerRight.ShowMessage("You hear a click.");
            }
            if (side == "left")
            {
                messageControllerLeft.ShowMessage("You hear a click.");
            }

            // //Change panels:
            // coffeeTableLeftPanel.SetActive(false);
            // coffeeTableRightPanel.SetActive(false);
            // livingRoomPanel.SetActive(true);

            //open Drawer, disable closed drawer, show key
            openDrawer.SetActive(true);
            leftButton.SetActive(false);
            rightButton.SetActive(false);
            closedDrawer.SetActive(false);
            showKey.SetActive(true);
        }
        if ((leftCode == correctCode1 &&
            rightCode != correctCode2 &&
            side == "left") ||
            (leftCode == correctCode2 &&
            rightCode != correctCode1 &&
            side == "left") ||
            (leftCode != correctCode1 &&
            rightCode == correctCode2 &&
            side == "right") ||
            (leftCode != correctCode2 &&
            rightCode == correctCode1 &&
            side == "right")
            )
        {
            if (side == "right") {
                Debug.Log("RIGHT message fired");
                messageControllerRight.ShowMessage("You hear a click.");
            }
            if (side == "left")
            {
                messageControllerLeft.ShowMessage("You hear a click.");
            }        }
        
    }
}