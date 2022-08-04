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
        "Spindle Support Clamp",              //3.
        "Work Roll chock Unclamp",            //4. 
        "Roll change car Forward",            //5. 
        "Mother Car Forward",                 //6. 
        "Work Roll Change Unclamp",           //7.
        "Baby Car Forward",                   //8.
        "Work Roll Change Clamp",             //9.
        "Baby Car Reverse",                   //10.
        "Mother Car Reverse",                 //11.
        "Roll Change Car Out",                //12.

        //Crane 해서 생긴 시퀀스
        "W/R Change UnClamp",                 //13.
        "Baby Car Out",                       //14.
        "Crane Button: W/R Crane",            //15.
        ///////////////////////////////////////////

        //Buttom Back Up Roll취외
        "Back Up Roll Chock Unclamp",         //16. +추가 된 부분 Bottom Back Up Roll 취외
        "Back Up Roll Change Car Forward",    //17
        "Back Up Roll Change Cylinder IN",    //18
        //Jog설치해서 취외
        "BUR CHange Clamp",                   //19 OUT JOG:
        "BUR Change Car Reverse",             //20 Out Jog

        //Jig 설치 후 Top Back Up Roll 취외
        "Crane Button: Zig Crane\nBack Up Roll 취외상태\nBottom Roll 위에 JIG설치 ",//21. Button 추가 
        "BuR Change lever Forward",           //22. Top Back Up Roll 취외 TOP Back UP Roll 취외
        "Back Up Roll Balance DOWN",          //23.
        "Back Up Roll Change OUT",            //24
        "Roll Cahnge Car Out",                //25

        "BuRCarane Button"                    //26. Top Back up Roll 취외 및 설치 준비
     };
     void Update(){
        step = GameObject.Find("Txt_stepNum").GetComponent<TXT_StepNUM>().StepNumber;
        if(step >= 1 && step<=26) txt_RealProcess.text=process[step-1];
        else if(step == 27) txt_RealProcess.text="Finish~~!";
        else txt_RealProcess.text="NULL";
    }
    
}
