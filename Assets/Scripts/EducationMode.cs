using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EducationMode : MonoBehaviour
{
  int[] EducationStep = new int[22];
  public int step;
  void Start(){
    step = 1;
    EducationStep[0] = 1;
    for(int i=0; i<22; i++) EducationStep[i] = 0;
  }
  
  void Update(){

    if(step==1 && Input.GetKeyUp(KeyCode.Alpha1))     {EducationStep[step-1]=0; EducationStep[step]=1;step++; Debug.Log("일");}
    else if(step==2 && Input.GetKeyUp(KeyCode.Alpha2)){EducationStep[step-1]=0; EducationStep[step]=1;step++;Debug.Log("이");}
    else if(step==3 && Input.GetKeyUp(KeyCode.Alpha3)){EducationStep[step-1]=0; EducationStep[step]=1;step++; Debug.Log("삼");}
    else if(step==4 && Input.GetKeyUp(KeyCode.Alpha4)){EducationStep[step-1]=0; EducationStep[step]=1;step++; Debug.Log("사");}
    else if(step==5 && Input.GetKeyUp(KeyCode.Alpha5)){EducationStep[step-1]=0; EducationStep[step]=1;step++; Debug.Log("오");}
    else if(step==6 && Input.GetKeyUp(KeyCode.Alpha6)){EducationStep[step-1]=0; EducationStep[step]=1;step++; Debug.Log("육");}
    else if(step==7 && Input.GetKeyUp(KeyCode.Alpha7)){EducationStep[step-1]=0; EducationStep[step]=1;step++; Debug.Log("칠");}
    else if(step==8 && Input.GetKeyUp(KeyCode.Alpha8)){EducationStep[step-1]=0; EducationStep[step]=1;step++; Debug.Log("팔");}
    else if(step==9 && Input.GetKeyUp(KeyCode.Alpha9)){EducationStep[step-1]=0; EducationStep[step]=1;step++; Debug.Log("구");}
  }
}
