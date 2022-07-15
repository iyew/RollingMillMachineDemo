using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject leftButton, rightButton;
    public Material greenActivate, greenDeactivate;
    public Material redActivate, redDeactivate;
    public bool isActivated;

    public void Toggle()
    {
        var leftLED = leftButton.GetComponent<Renderer>().material;
        var rightLED = rightButton.GetComponent<Renderer>().material;

        if (isActivated)
        {
            leftLED.color = greenActivate.color;
            rightLED.color = redDeactivate.color;
            isActivated = false;
        }
        else
        {
            leftLED.color = greenDeactivate.color;
            rightLED.color = redActivate.color;
            isActivated = true;
        }
    }
}
