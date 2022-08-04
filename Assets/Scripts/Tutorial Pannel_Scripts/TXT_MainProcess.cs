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
        else if(step >=13 && step < 16)  {txt_MainProcess.text="취외 된 Work Roll Crane 이용하여 빼기";}
        else if(step >=16 && step <21)   {txt_MainProcess.text="Bottom Back Up Roll 취외";}
        else if(step >=21 && step < 27)  {txt_MainProcess.text="TOP Back UP Roll 취외";}
        else if(step == 27)              {txt_MainProcess.text="Finish";}
        else                             {txt_MainProcess.text="NULL";}
    }
}
