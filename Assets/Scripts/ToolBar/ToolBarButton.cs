using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToolBarButton : MonoBehaviour
{
    bool              monitoring,       tutorial;
    public GameObject ovrCameraRig,     tutorialPannel;
    public GameObject MonitoringButton, TutorialButton;
    public Sprite     MonitoringOn,     TutorialOn;
    public Sprite     MonitoringOff,    TutorialOff;

    void Start(){
        monitoring = false;
        tutorial = false;

        ovrCameraRig.GetComponent<Monitoring>().enabled=false;
        tutorialPannel.SetActive(false);
    }

    public void Monitoring(){
        if(monitoring)            {MonitoringButton.GetComponent<Image>().sprite = MonitoringOff; ovrCameraRig.GetComponent<Monitoring>().enabled=false; monitoring = false;}
        else if(monitoring==false){MonitoringButton.GetComponent<Image>().sprite = MonitoringOn;  ovrCameraRig.GetComponent<Monitoring>().enabled=true; monitoring = true;}
    }
    public void Tutorial(){
        if(tutorial)            {TutorialButton.GetComponent<Image>().sprite = TutorialOff; tutorialPannel.SetActive(false); tutorial = false;}
        else if(tutorial==false){TutorialButton.GetComponent<Image>().sprite = TutorialOn;  tutorialPannel.SetActive(true); tutorial = true;}
    }
}
