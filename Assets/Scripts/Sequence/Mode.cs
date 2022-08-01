using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mode : MonoBehaviour
{
  public GameObject machineController;
  public GameObject Environment_light;
  public int step;
   
  int[] EducationStep = new int[22];
  int[] state = new int[8];
  int[] state_copy = new int[8];

  int Nume, Action; 
  private float time;

  void Start(){
    step = 1;
    Environment_light.GetComponent<Light>().color = Color.white;
    for(int i = 0; i<8; i++) state_copy[i]=2;
  }
  
  void Update(){

    if(machineController.GetComponent<ControlllerStep>().action == 1){

      state = machineController.GetComponent<ControlllerStep>().MenuState;
      Nume  = machineController.GetComponent<ControlllerStep>().num;
      Action= machineController.GetComponent<ControlllerStep>().action;


      if(step==1 && state[step-1]==1)      {step++; Action= 0; state_copy = state;}
      else if(step==2 && state[step-1]==1) {step++; Action= 0; state_copy = state;}
      else if(step==3 && state[step-1]==0) {step++; Action= 0; state_copy = state;}
      else if(step==4 && state[step-1]==1) {step++; Action= 0; state_copy = state;}
      else if(step==5 && state[step-1]==0) {step++; Action= 0; state_copy = state;}
      else if(step==6 && state[step-1]==0) {step++; Action= 0; state_copy = state;}
      else if(step==7 && state[step-1]==1) {step++; Action= 0; state_copy = state;}
      else if(step==8 && state[step-1]==0) {step++; Action= 0; state_copy = state;}
      else if(step==9)                     {step++; Action= 0; state_copy = state;}
      else{
        Debug.Log("state_copy:"+state_copy+"state:"+state);
        Debug.Log("Wrong!!!"+ Nume +":"+state[Nume]+"->"+state_copy[Nume]);
        state[Nume] = state_copy[Nume];
        
        time +=Time.deltaTime;
        if(time<1.0f) {Environment_light.GetComponent<Light>().color = Color.red; /*System.Media.SystemSounds.Beep.Play();*/}
        else {time = 0; Environment_light.GetComponent<Light>().color = Color.white; machineController.GetComponent<ControlllerStep>().action = 0; state_copy = state;} 

      }
      Debug.Log(state[0]*10000000+state[1]*1000000+state[2]*100000+state[3]*10000+state[4]*1000+state[5]*100+state[6]*10+state[7]);
    }
  }
}
