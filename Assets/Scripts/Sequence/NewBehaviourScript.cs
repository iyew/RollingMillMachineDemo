using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject machineController;
    public GameObject RollingMillmachine_workrollTop;
    public GameObject RollingMillmachine_RollchangeCar;
    int renum;
    int restate;

    public void CorrectState(){

        renum =  machineController.GetComponent<Mode>().Nume;
        restate = machineController.GetComponent<Mode>().state_copy[renum];

        if(renum == 4){
            if(restate == ControlllerStep.Forward || restate == 2)        {RollingMillmachine_RollchangeCar.GetComponent<Car>().Forward(); Debug.Log("set 원점");}
            else if(restate ==  ControlllerStep.Reverse)  {RollingMillmachine_RollchangeCar.GetComponent<Car>().Reverse();}
        }
    }

    public void Update(){
        if(machineController.GetComponent<Mode>().step == 15){
            RollingMillmachine_workrollTop.GetComponent<CylinderCollisionTrigger>().enabled = true;
        }
    }
}
