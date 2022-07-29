using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode : MonoBehaviour
{
  public GameObject machineController;
  public int step;
   
  int[] EducationStep = new int[22];
  int[] state = new int[8];

  int Nume;

  void Start(){
    step = 1;
  }
  
  void Update(){
    if(step==1 && Input.GetKeyUp(KeyCode.Alpha1)){step++; machineController.GetComponent<ControlllerStep>().action = 1;}

    if(machineController.GetComponent<ControlllerStep>().action == 1){
      state = machineController.GetComponent<ControlllerStep>().MenuState;
      Nume  = machineController.GetComponent<ControlllerStep>().num;

      if(step==2 && state[step-1]==1) {step++;}
      else if(step==3 && state[step-1]==0) {step++;}
      else if(step==4 && state[step-1]==1) {step++;}
      else if(step==5 && state[step-1]==0) {step++;}
      else if(step==6 && state[step-1]==0) {step++;}
      else if(step==7 && state[step-1]==1) {step++;}
      else if(step==8 && state[step-1]==0) {step++;}
      else if(step==9)                     {step++;}
      else{
        state[Nume] = 2;
        Debug.Log("Wrong!!!"+Nume);
      }
      Debug.Log(state[0]*10000000+state[1]*1000000+state[2]*100000+state[3]*10000+state[4]*1000+state[5]*100+state[6]*10+state[7]);
      machineController.GetComponent<ControlllerStep>().action = 0;
    }
    
    if(machineController.GetComponent<ControlllerStep>().action == 0) Debug.Log("아무튼 안움직임");
    else if(machineController.GetComponent<ControlllerStep>().action == 1) Debug.Log("아무튼 움직임");
  }
}
