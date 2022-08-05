using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TXT_RealProcess : MonoBehaviour
{
     public TextMeshProUGUI txt_RealProcess;
     int step;
     string[] process = new string[]{
        "LED에 조명 들어오는지 확인",          //LampTest
        "Roll Force Cylinder Down\n(Roll 교환을 위한 위치로1)",           //1. Roll Change 준비
        "Work Roll Balance Cylincder Down\n(Work Roll 교환을 위한 위치로2)",   //2. Work Roll 취외
        "Spindle Support Clamp\n(Work Roll취외 시 무너지지 않게 고정)",  //3.
        "Work Roll Chock Unclamp\n(Work Roll 지지 해제)",                //4. 
        "Roll Change Car Forward\n(WorkRoll 빼낼 차1 앞으로)",            //5. 
        "Mother Car Forward\n(Work Roll 빼낼 차2 앞으로)",                 //6. 
        "Work Roll Change Unclamp\n(집게 열어 Work Roll 물기 준비)",           //7.
        "Baby Car Forward\n(Work Roll 빼낼 차3 앞으로)",                   //8.
        "Work Roll Change Clamp\n(집게 열어 Work Roll 물기)",             //9.
        "Baby Car Reverse\n(Work Roll 빼낸 차3 원 위치로)",                   //10.
        "Mother Car Reverse\n(Work Roll 빼낸 차2 원 위치로)",                 //11.
        "Roll Change Car Out\n(Work Roll 빼낸 차1 원 위치로",                //12.

        //Crane 해서 생긴 시퀀스
        "Work Roll Change UnClamp\n(집게 열어(고정 해제) Work Roll 가져 갈 수 있도록)",                 //13.
        "Baby Car Out\n(Crane이 집어 갈 수 있도록, Work Roll  빼낸 차3 위치로)",                       //14.
        "Crane Button: Work Roll Crane\n(빼낸 Work Roll, Crane을 이용하여 옮기기)",            //15.
        ///////////////////////////////////////////

        //Buttom Back Up Roll취외
        "Back Up Roll Chock Unclamp\n(Back Up Roll 지지 해제)",         //16. +추가 된 부분 Bottom Back Up Roll 취외
        "Back Up Roll Change Car Forward\n(Buttom Back Up Roll 빼낼 차1 앞으로)",    //17
        "Back Up Roll Change Cylinder Forword\n(Buttom Back Up Roll 빼낼 실린더 앞으로)",    //18
        //Jog설치해서 취외
        "Back Up Roll Change Clamp\n(몰라)",                   //19 OUT JOG:
        "Back Up Roll Change Car Reverse\n(Buttom Back up Roll 빼낸 실린더 원 위치로)",             //20 Out Jog
        "Roll Chanage Car Reverse\n(Buttom Back Up Roll 빼낸 차1 원 위치로)",            //21

        //Jig 설치 후 Top Back Up Roll 취외
        "Crane Button: Zig Crane\n(Bottom Roll 위에 JIG설치 하여 Top Roll도 빼서 올릴 수 있도록)",//22. Button 추가 
        "RollChanage Car Forward\n(Top Back Up Roll 빼낼 차1 앞으로)",           //23
        "Back Up Roll Change Car Forward\n(Top Back Up Roll 빼낼 실린더 앞으로)",           //24. Top Back Up Roll 취외 TOP Back UP Roll 취외
        "Back Up Roll Balance DOWN\n(Top Back Up Roll이 Zig위에 올려짐)",          //25.
        "Back Up Roll Change Reverse\n(Buttom/Top Back Up Roll 빼낸 실린더 원 위치로)",            //26
        "Roll Cahnge Car Out\n(Buttom/Top Back Up Roll 빼낸 차1 원 위치로)",                //27

        "BuRCarane Button\n(빼낸 Back Up Roll(Top/Buttom), Crane을 이용하여 옮기기)"                    //28. Top Back up Roll 취외 및 설치 준비
     };
     void Update(){
        step = GameObject.Find("Txt_stepNum").GetComponent<TXT_StepNUM>().StepNumber;
        if(step >= 0 && step<29) txt_RealProcess.text=process[step];
        else if(step == 29) txt_RealProcess.text="Finish~~!";
        else txt_RealProcess.text="NULL";
    }
    
}
