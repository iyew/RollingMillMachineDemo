using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToolBarButton : MonoBehaviour
{
    bool              monitoring,       manual,         tutorial;
    public GameObject ovrCameraRig,     tutorialPannel, machineCotroller,      position_anaunce;
    public GameObject MonitoringButton, ManualButton,   TutorialButton;
    public Sprite     MonitoringOn,     ManualOn,       TutorialOn;
    public Sprite     MonitoringOff,    ManualOff,      TutorialOff;

    void Start(){
        monitoring = false;
        tutorial = false;
        manual   = true;

        ovrCameraRig.GetComponent<Monitoring>().enabled=false;

        ManualButton.GetComponent<Image>().sprite = ManualOn;

        position_anaunce.SetActive(false);
        tutorialPannel.SetActive(false);
    }

    public void Monitoring(){
        if(monitoring)            {MonitoringButton.GetComponent<Image>().sprite = MonitoringOff; ovrCameraRig.GetComponent<Monitoring>().enabled=false; monitoring = false;}
        else if(monitoring==false){MonitoringButton.GetComponent<Image>().sprite = MonitoringOn;  ovrCameraRig.GetComponent<Monitoring>().enabled=true; monitoring = true;}
    }/*
    public void Manual(){
        if(tutorial)            {TutorialButton.GetComponent<Image>().sprite = ManualOff; tutorialPannel.SetActive(false); tutorial = false;}
        else if(tutorial==false){TutorialButton.GetComponent<Image>().sprite = ManualOn;  tutorialPannel.SetActive(true); tutorial = true;}
    }*/
    public void Tutorial(){
        if(tutorial)            {TutorialButton.GetComponent<Image>().sprite = TutorialOff; tutorialPannel.SetActive(false); tutorial = false;}
        else if(tutorial==false){
            ManualButton.GetComponent<Image>().sprite = ManualOff;

            machineCotroller.GetComponent<Mode>().step=1;

            TutorialButton.GetComponent<Image>().sprite = TutorialOn;  
            position_anaunce.SetActive(true);
            tutorialPannel.SetActive(true); tutorial = true;
            }
    }
}
