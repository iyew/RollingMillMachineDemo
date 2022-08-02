using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class ButtonController : MonoBehaviour
{
    public GameObject leftButton, rightButton;
    public bool isActivated;
    private InteractableColorVisual.ColorState leftColorState, rightColorState;
    private Color greenOn, greenOff, redOn, redOff;

    void Start()
    {
        leftColorState = new InteractableColorVisual.ColorState();
        rightColorState = new InteractableColorVisual.ColorState();

        greenOn = new Color(0, 255, 0, 255);
        greenOff = new Color(0, 127, 0, 127);
        redOn = new Color(255, 0, 0, 255);
        redOff = new Color(127, 0, 0, 127);
        
        Toggle();
    }

    public void Toggle()
    {
        var leftLED = leftButton.GetComponent<InteractableColorVisual>();
        var rightLED = rightButton.GetComponent<InteractableColorVisual>();

        if (isActivated)
        {
            leftColorState.Color = greenOn;
            leftLED.InjectOptionalNormalColorState(leftColorState);

            rightColorState.Color = redOff;
            rightLED.InjectOptionalNormalColorState(rightColorState);

            isActivated = false;
        }
        else
        {
            leftColorState.Color = greenOff;
            leftLED.InjectOptionalNormalColorState(leftColorState);

            rightColorState.Color = redOn;
            rightLED.InjectOptionalNormalColorState(rightColorState);

            isActivated = true;
        }
    }
}
