using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToolBarButton : MonoBehaviour
{
    public bool              monitoring,       manual,         tutorial,         test;
    public GameObject ovrCameraRig, tutorialPannel, machineCotroller, position_anaunce;
    public GameObject MonitoringButton, ManualButton,   TutorialButton,   TestButton;
    public Sprite     MonitoringOn,     ManualOn,       TutorialOn,       TestOn;
    public Sprite     MonitoringOff,    ManualOff,      TutorialOff,      TestOff;

    void Start(){
        //Manual Default
        monitoring = false;
        ovrCameraRig.GetComponent<Monitoring>().enabled=false;

        ManualButton.GetComponent<Image>().sprite = ManualOn;
        manual   = true;

        tutorialPannel.SetActive(false);
        position_anaunce.SetActive(false);
        machineCotroller.GetComponent<ControlllerStep>().enabled=false;
        tutorial = false;

        test = false;
    }

    public void Monitoring(){  //언제든 발동 해되 괜찮음 (수정 하지 않아도 됨)
        if(monitoring)            {MonitoringButton.GetComponent<Image>().sprite = MonitoringOff; ovrCameraRig.GetComponent<Monitoring>().enabled=false; monitoring = false;}
        else if(monitoring==false){MonitoringButton.GetComponent<Image>().sprite = MonitoringOn;  ovrCameraRig.GetComponent<Monitoring>().enabled=true; monitoring = true;}
    }

    
    public void Manual(){/*
        if(manual){
            ManualButton.GetComponent<Image>().sprite = ManualOff; 
            tutorialPannel.SetActive(false); 
            manual = false;
        }
        else*/ if(manual==false){
            ManualButton.GetComponent<Image>().sprite = ManualOn;  
            manual = true;  

            TutorialButton.GetComponent<Image>().sprite = TutorialOff; 
            tutorialPannel.SetActive(false);
            position_anaunce.SetActive(false);
            machineCotroller.GetComponent<ControlllerStep>().enabled=false;
            tutorial = false;

            TestButton.GetComponent<Image>().sprite = TestOff;
            test=false;
        }
    }


    public void Tutorial(){
        /*
        if(tutorial){
            TutorialButton.GetComponent<Image>().sprite = TutorialOff; 
            tutorialPannel.SetActive(false); tutorial = false;
        }*/
        /*else*/ 
        if(tutorial==false){

            ManualButton.GetComponent<Image>().sprite = ManualOff;
            manual = false;

            if(test != true) machineCotroller.GetComponent<Mode>().step=0;

            TutorialButton.GetComponent<Image>().sprite = TutorialOn;  
            position_anaunce.SetActive(true);
            tutorialPannel.SetActive(true); 
            machineCotroller.GetComponent<ControlllerStep>().enabled=true;
            tutorial = true;

            TestButton.GetComponent<Image>().sprite = TestOff;
            test=false;
        }
    }

    public void Test(){
        if(test==false){

            ManualButton.GetComponent<Image>().sprite = ManualOff;
            manual = false;

            machineCotroller.GetComponent<Mode>().step=0;

            TutorialButton.GetComponent<Image>().sprite = TutorialOff;  
            position_anaunce.SetActive(false);
            tutorialPannel.SetActive(false);
            machineCotroller.GetComponent<ControlllerStep>().enabled=true; 
            tutorial = false;

            TestButton.GetComponent<Image>().sprite = TestOn; 
            test= true;
        }
    }
}
