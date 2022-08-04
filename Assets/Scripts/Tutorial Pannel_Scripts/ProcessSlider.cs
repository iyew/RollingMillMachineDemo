using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProcessSlider : MonoBehaviour
{
    public Slider sliderA;

    public int Step_Current= 0;
    int Step_Full=29;


    void Update(){
       Step_Current = GameObject.Find("Txt_stepNum").GetComponent<TXT_StepNUM>().StepNumber;
       sliderA.value = (float)Step_Current/Step_Full;
    }
}
