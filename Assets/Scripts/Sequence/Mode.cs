using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Mode : MonoBehaviour
{

  public GameObject machineController;
  public GameObject Environment_light;
  public int step;
   
  int[] EducationStep = new int[22];
  int[] state = new int[10];
  int[] state_copy = new int[10];

  int Nume, Action, flag=0; 
  private float time;

  void Start(){
    step = 1;
    Environment_light.GetComponent<Light>().color = Color.white;
    for(int i = 0; i<10; i++) state_copy[i]=2;
  }
  
  void Update(){
    state = machineController.GetComponent<ControlllerStep>().MenuState;
    Nume  = machineController.GetComponent<ControlllerStep>().num;

    //Debug.Log("step: "+ step + "Action: "+machineController.GetComponent<ControlllerStep>().action);

    if(machineController.GetComponent<ControlllerStep>().action == 1){

      if(step==1 && state[ControlllerStep.RFCy]          == ControlllerStep.Down)     flag = 1;
      else if(step==2  && state[ControlllerStep.WRBCy]   == ControlllerStep.Down)     flag = 1;
      else if(step==3  && state[ControlllerStep.SpSup]   == ControlllerStep.Clamp)    flag = 1;
      else if(step==4  && state[ControlllerStep.WRCh]    == ControlllerStep.UnClamp)  flag = 1;
      else if(step==5  && state[ControlllerStep.RCC]     == ControlllerStep.Forward)  flag = 1;
      else if(step==6  && state[ControlllerStep.MomCar]  == ControlllerStep.Forward)  flag = 1;
      else if(step==7  && state[ControlllerStep.WRC]     == ControlllerStep.UnClamp)  flag = 1;
      else if(step==8  && state[ControlllerStep.Babycar] == ControlllerStep.Forward)  flag = 1;
      else if(step==9  && state[ControlllerStep.WRC]     == ControlllerStep.Clamp)    flag = 1;
      else if(step==10 && state[ControlllerStep.Babycar] == ControlllerStep.Reverse)  flag = 1;
      else if(step==11 && state[ControlllerStep.MomCar]  == ControlllerStep.Reverse)  flag = 1;
      else if(step==12 && state[ControlllerStep.RCC]     == ControlllerStep.Reverse)  flag = 1;
      else if(step==13 && state[ControlllerStep.BURCH]   == ControlllerStep.UnClamp)  flag = 1;
      else if(step==14 && state[ControlllerStep.RCC]     == ControlllerStep.Forward)  flag = 1;
      else if(step==15 && state[ControlllerStep.BURCC]   == ControlllerStep.Forward)  flag = 1;
      else if(step==16 && state[ControlllerStep.BURCC]   == ControlllerStep.Reverse)  flag = 1;
      //JIG설치 후
      else if(step==17 && state[ControlllerStep.BURCH]   == ControlllerStep.UnClamp)  flag = 1;
      else if(step==18 && state[ControlllerStep.BURCC]   == ControlllerStep.Forward)  flag = 1;
      else if(step==19 && state[ControlllerStep.BURCC]   == ControlllerStep.Reverse)  flag = 1;
      else if(step==20 && state[ControlllerStep.RCC]     == ControlllerStep.Reverse)  flag = 1;
      else{
        Debug.Log("You Put Wron Number: " + "num-"+ Nume +  "Movement-" + state[Nume]);
                
        time +=Time.deltaTime;
        if(time<1.0f) {Environment_light.GetComponent<Light>().color = Color.red;}
        else {
          machineController.GetComponent<ControlllerStep>().action=0; time = 0.0f; 
          Environment_light.GetComponent<Light>().color = Color.white;  
          machineController.GetComponent<ControlllerStep>().MenuState[Nume] = state_copy[Nume];
          } 
      }

      if(flag == 1){
        state_copy[Nume] = state[Nume]; step++; flag = 0; machineController.GetComponent<ControlllerStep>().action=0;
        Debug.Log(state[0]*10000000+state[1]*1000000+state[2]*100000+state[3]*10000+state[4]*1000+state[5]*100+state[6]*10+state[7]);
      }
    }
  }
}

