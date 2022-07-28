using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EducationMode : MonoBehaviour
{
  public GameObject machineController;
  int[] EducationStep = new int[22];
  public int step;
  public int stepstate;
  void Start(){
    step = 1;
    EducationStep[0] = 1;
    for(int i=0; i<22; i++) EducationStep[i] = 0;
  }
  
  void Update(){
    
    stepstate = machineController.GetComponent<ControlllerStep>().MenuState[step-1];

    if(step==1 && Input.GetKeyUp(KeyCode.Alpha1))        {EducationStep[step-1]=0; EducationStep[step]=1;step++;}
    else if(step==2 && Input.GetKeyUp(KeyCode.Alpha2))   {EducationStep[step-1]=0; EducationStep[step]=1;step++;}
    else if(step==3 && stepstate==0) {EducationStep[step-1]=0; EducationStep[step]=1;step++;}
    else if(step==4 &&stepstate==1)  {EducationStep[step-1]=0; EducationStep[step]=1;step++;}
    else if(step==5 && stepstate==0) {EducationStep[step-1]=0; EducationStep[step]=1;step++;}
    else if(step==6 && stepstate==0) {EducationStep[step-1]=0; EducationStep[step]=1;step++;}
    else if(step==7 && stepstate==1) {EducationStep[step-1]=0; EducationStep[step]=1;step++;}
    else if(step==8 && stepstate==0) {EducationStep[step-1]=0; EducationStep[step]=1;step++;}
    else if(step==9)                 {EducationStep[step-1]=0; EducationStep[step]=1;step++;}
  }
}
