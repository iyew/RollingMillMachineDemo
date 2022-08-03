using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Mode : MonoBehaviour
{
  public SoundManager soundManager;
  public GameObject machineController;
  public GameObject Environment_light;
  public int step;
   
  int[] EducationStep = new int[22];
  int[] state = new int[10];
  int[] state_copy = new int[10];

  int Nume, Action, flag=0, sound_flag=1; 
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
      /*
      else if(step==13 && state[ControlllerStep.BURCH]   == ControlllerStep.UnClamp)  flag = 1;
      else if(step==14 && state[ControlllerStep.RCC]     == ControlllerStep.Forward)  flag = 1;
      else if(step==15 && state[ControlllerStep.BURCC]   == ControlllerStep.Forward)  flag = 1;
      else if(step==16 && state[ControlllerStep.BURCC]   == ControlllerStep.Reverse)  flag = 1;
      
      else if(step==17 && state[ControlllerStep.BURCH]   == ControlllerStep.UnClamp)  flag = 1;
      else if(step==18 && state[ControlllerStep.BURCC]   == ControlllerStep.Forward)  flag = 1;
      else if(step==19 && state[ControlllerStep.BURCC]   == ControlllerStep.Reverse)  flag = 1;
      else if(step==20 && state[ControlllerStep.RCC]     == ControlllerStep.Reverse)  flag = 1;*/
      else{
        //Debug.Log("You Put Wron Number: " + "num-"+ Nume +  "Movement-" + state[Nume]);
        if(sound_flag==1)  {soundManager.play_Error(); sound_flag = 0;}
                
        time +=Time.deltaTime;
        if(time<1.0f) {Environment_light.GetComponent<Light>().color = Color.red;}
        else {
          machineController.GetComponent<ControlllerStep>().action=0; time = 0.0f; 
          Environment_light.GetComponent<Light>().color = Color.white;  
          machineController.GetComponent<ControlllerStep>().MenuState[Nume] = state_copy[Nume];
          sound_flag = 1;
          } 
      }

      if(flag == 1){
        soundManager.play_Next();
        state_copy[Nume] = state[Nume]; step++; flag = 0; machineController.GetComponent<ControlllerStep>().action=0;
        Debug.Log(state[0]*1000000000+state[1]*100000000+state[2]*10000000+state[3]*1000000+state[4]*100000+state[5]*10000+state[6]*1000+state[7]*100+state[8]*10+state[9]);
      }
    }
  }
}

