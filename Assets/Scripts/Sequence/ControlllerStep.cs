using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlllerStep : MonoBehaviour
{   public int num; 
    public const int Clamp   = 0;
    public const int UnClamp = 1;
    public const int Forward = 0;
    public const int Reverse = 1;
    public const int Up      = 0;
    public const int Down    = 1;

    public const int RFCy    = 0;
    public const int WRBCy   = 1;
    public const int SpSup   = 2;
    public const int WRCh    = 3;
    public const int RCC     = 4;
    public const int MomCar  = 5;
    public const int WRC     = 6;
    public const int Babycar = 7;
    public const int BURCH   = 8;
    public const int BURCC   = 9;

    public int[] MenuState;
    public int action;

    void Start(){
        action = 0;
        MenuState = new int[10];
        for(int i=0; i<10; i++) MenuState[i]=2;
    }

    public void RFCyUp()  {MenuState[RFCy]= Up;                num=0; action=1;}
    public void RFCyDown(){MenuState[RFCy]= Down;              num=0; action=1;}

    public void WRBCyUp()  {MenuState[WRBCy]= Up;              num=1; action=1;} 
    public void WRBCyDown(){MenuState[WRBCy]= Down;            num=1; action=1;}

    public void SpSupClamp()  {MenuState[SpSup]= Clamp;        num=2; action=1;}
    public void SpSupUnClamp(){MenuState[SpSup]= UnClamp;      num=2; action=1;}
    
    public void WRChClamp()   {MenuState[WRCh]= Clamp;         num=3; action=1;}
    public void WRChUnClamp() {MenuState[WRCh]= UnClamp;       num=3; action=1;}

    public void RCCForward()  {MenuState[RCC]= Forward;        num=4; action=1;}
    public void RCCBackward() {MenuState[RCC]= Reverse;        num=4; action=1;}

    public void MomCarForward() {MenuState[MomCar]= Forward;   num=5; action=1;}
    public void MomCarBackward(){MenuState[MomCar]= Reverse;   num=5; action=1;}

    public void WRCClamp()  {MenuState[WRC]= Clamp;            num=6; action=1;}
    public void WRCUnClamp(){MenuState[WRC]= UnClamp;          num=6; action=1;}
    
    public void BabycarForward() {MenuState[Babycar]= Forward; num=7; action=1;}
    public void BabycarBackward(){MenuState[Babycar]= Reverse; num=7; action=1;}

    public void BURCHClamp()     {MenuState[BURCH]=Clamp; num=8; action=1;}
    public void BURCHUnClamp()   {MenuState[BURCH]=UnClamp; num=8; action=1;}

    public void BURCCForward()  {MenuState[BURCC]= Forward; num=9; action=1;}
    public void BURCCBackward() {MenuState[BURCC]= Reverse; num=9; action=1;}
}
