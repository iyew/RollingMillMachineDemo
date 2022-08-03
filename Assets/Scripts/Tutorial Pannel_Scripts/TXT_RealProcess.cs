using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TXT_RealProcess : MonoBehaviour
{
     public TextMeshProUGUI txt_RealProcess;
     int step;
     string[] process = new string[]{
        "Roll Force Cylinder Down",           //1. Roll Change 준비
        "Work Roll Balance Cylincder Down",   //2. Work Roll 취외
        "Spindle Support clamp",              //3.
        "Work Roll chock Unclamp",            //4. 
        "Roll change car Forward",            //5. 
        "Mother Car Forward",                 //6. 
        "Work Roll Change Unclamp",           //7.
        "Baby Car Forward",                   //8.
        "Work Roll Change Clamp",             //9.
        "Baby Car Reverse",                   //10.
        "Mother Car Reverse",                 //11.
        "Roll Change Car  Out",               //12.
        //Crane 해서 생긴 시퀀스
        "W/R Change UnClamp",                 //13.
        "+Baby Car Out",                      //14.(했다치고 아니고 물리적으로)
        "Crane Button",                       //15.
        ///////////////////////////////////////////
        "Back Up Roll Chock Unclamp",         //16. +추가 된 부분 Bottom Back Up Roll 취외
        "Back Up Roll Change Car IN",         //17
        "Back Up Roll Change Cylinder IN",    //18
        "BuR CHange Button Clamp",            //19 OUT JOG:
        "BUR Change Lever Back",              //19 Out Jog
        "Back Up Roll 취외상태\nBottom Roll 위에 JIG설치 ",//20. Button 추가 
        "BuR Change lever Forward",           //21. Top Back Up Roll 취외 TOP Back UP Roll 취외
        "Back Up Roll Balance DOWN",          //22.
        "Back Up Roll Change OUT",            //23
        "Roll Cahnge Car Out",                //24

        "BuRCarane Button"                    //25. Top Back up Roll 취외 및 설치 준비
     };
     void Update(){
        step = GameObject.Find("Txt_stepNum").GetComponent<TXT_StepNUM>().StepNumber;
        if(step >= 1 && step<=22) txt_RealProcess.text=process[step-1];
        else txt_RealProcess.text="NULL";
    }
    
}
