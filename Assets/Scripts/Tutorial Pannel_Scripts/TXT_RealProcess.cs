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
        "Roll Change Car Cylinder Out",       //12.
        "Back Up Roll Chock Unclamp",         //13. Bottom Back Up Roll 취외
        "Roll change Car IN",                 //14
        "Back Up Roll Change Cylinder IN",    //15
        "Back Up Roll Change OUT JOG\n: 하부 Back Up Roll 취외상태\nBottom Roll 위에 JIG설치 ",//16
        "Back Up Roll Chock UnClamp",         //17
        "Back up Roll Change In JOG",         //18. TOP Back UP Roll 취외
        "Back Up Roll Balance DOWN",          //19
        "Back Up Roll Change OUT",            //20
        "Roll Cahnge Car Out",                //21
        "Zig 보관대 이동 및 BUR 보관대 이동(수동)"  //22. Top Back up Roll 취외 및 설치 준비
     };
     void Update(){
        step = GameObject.Find("Txt_stepNum").GetComponent<TXT_StepNUM>().StepNumber;
        if(step >= 1 && step<=22) txt_RealProcess.text=process[step-1];
        else txt_RealProcess.text="NULL";
    }
    
}
