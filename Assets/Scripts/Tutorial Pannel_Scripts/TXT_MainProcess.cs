using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TXT_MainProcess : MonoBehaviour
{
    public TextMeshProUGUI txt_MainProcess;
    int step;


    void Update(){
        step = GameObject.Find("Txt_stepNum").GetComponent<TXT_StepNUM>().StepNumber;
        if(step == 1)                    {txt_MainProcess.text="Roll Change 준비"; }
        else if(step >= 2 && step < 13)  {txt_MainProcess.text="Work Roll 취외";}
        else if(step >=13 && step < 18)  {txt_MainProcess.text="Bottom Back Up Roll 취외";}
        else if(step >=18 && step < 22)  {txt_MainProcess.text="TOP Back UP Roll 취외";}
        else if(step == 22)              {txt_MainProcess.text="TOP Back UP Roll 취외 및 설치 준비";}
        else                             {txt_MainProcess.text="NULL";}
    }
}
