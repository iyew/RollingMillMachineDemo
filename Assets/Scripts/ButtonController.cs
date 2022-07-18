using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class ButtonController : MonoBehaviour
{
    public GameObject leftButton, rightButton;
    public bool isActivated;
    private InteractableColorVisual.ColorState leftColorState, rightColorState;

    void Start()
    {
        leftColorState = new InteractableColorVisual.ColorState();
        rightColorState = new InteractableColorVisual.ColorState();
        Toggle();
    }

    public void Toggle()
    {
        var leftLED = leftButton.GetComponent<InteractableColorVisual>();
        var rightLED = rightButton.GetComponent<InteractableColorVisual>();

        if (isActivated)
        {
            leftColorState.Color = new Color(0, 255, 0, 255);
            leftLED.InjectOptionalNormalColorState(leftColorState);

            rightColorState.Color = new Color(127, 0, 0, 127);
            rightLED.InjectOptionalNormalColorState(rightColorState);

            isActivated = false;
        }
        else
        {
            leftColorState.Color = new Color(0, 127, 0, 127);
            leftLED.InjectOptionalNormalColorState(leftColorState);

            rightColorState.Color = new Color(255, 0, 0, 255);
            rightLED.InjectOptionalNormalColorState(rightColorState);

            isActivated = true;
        }
    }
}
