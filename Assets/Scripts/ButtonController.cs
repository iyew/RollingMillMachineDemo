using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class ButtonController : MonoBehaviour
{
    public GameObject leftButton, rightButton;
    public bool isActivated;
    private InteractableColorVisual leftLED, rightLED;
    private InteractableColorVisual.ColorState leftColorState, rightColorState;
    private Color greenOn, greenOff, redOn, redOff;

    void Awake()
    {
        leftLED = leftButton.GetComponent<InteractableColorVisual>();
        rightLED = rightButton.GetComponent<InteractableColorVisual>();

        leftColorState = new InteractableColorVisual.ColorState();
        rightColorState = new InteractableColorVisual.ColorState();
        //Debug.Log($"leftColorState: {leftColorState.Color}, {leftColorState.ColorCurve}, {leftColorState.ColorTime}");

        greenOn = new Color(0, 1.0f, 0, 1.0f);
        greenOff = new Color(0, 0.5f, 0, 0.5f);
        redOn = new Color(1.0f, 0, 0, 1.0f);
        redOff = new Color(0.5f, 0, 0, 0.5f);
        
        Toggle();
    }

    public void Toggle()
    {
        if (isActivated)
        {
            leftColorState.Color = greenOn;
            //Debug.Log($"leftColorState: {leftColorState.Color}, {leftColorState.ColorCurve}, {leftColorState.ColorTime}");
            leftLED.InjectOptionalNormalColorState(leftColorState);

            rightColorState.Color = redOff;
            rightLED.InjectOptionalNormalColorState(rightColorState);
        }
        else
        {
            leftColorState.Color = greenOff;
            leftLED.InjectOptionalNormalColorState(leftColorState);

            rightColorState.Color = redOn;
            rightLED.InjectOptionalNormalColorState(rightColorState);
        }
    }

    public void setActivate()
    {
        isActivated = true;
    }

    public void setDeactivate()
    {
        isActivated = false;
    }
}
