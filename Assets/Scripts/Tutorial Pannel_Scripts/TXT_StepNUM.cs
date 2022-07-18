using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TXT_StepNUM : MonoBehaviour
{
    public int StepNumber;
    public TextMeshProUGUI txt_StepNum;

    void Update(){
        txt_StepNum.text="STEP:"+StepNumber;
    }
}
