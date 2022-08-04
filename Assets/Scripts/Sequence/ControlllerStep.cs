using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlllerStep : MonoBehaviour
{        
    public int num; 
    public const int Clamp   = 0;
    public const int UnClamp = 1;
    public const int Forward = 0;
    public const int Reverse = 1;
    public const int Up      = 0;
    public const int Down    = 1;
    public const int Mount = 0;
    public const int UnMOunt = 1;

    public const int RFCy    = 0; //W/R
    public const int WRBCy   = 1;
    public const int SpSup   = 2;
    public const int WRCh    = 3;
    public const int RCC     = 4;
    public const int MomCar  = 5;
    public const int WRC     = 6;
    public const int Babycar = 7;
    public const int BURBCY  = 8;  //BUR
    public const int BURCH   = 9;
    public const int BURC    = 10;
    public const int BURCC   = 11;
    public const int WRCrane = 12;  //Crane
    public const int ZigCrane= 13;
    public const int BURCrane=14;

    public int[] State;
    public int[] Crane;
    public int action;

    void Start(){
        action = 0;
        State = new int[15];
        for(int i=0; i<15; i++) State[i]=2;
    }
    public void LampTest()       {if(this.GetComponent<Mode>().step==0) this.GetComponent<Mode>().step++;}
    public void RFCyUp()         {State[RFCy]= Up;           num=0; action=1;}
    public void RFCyDown()       {State[RFCy]= Down;         num=0; action=1;}

    public void WRBCyUp()        {State[WRBCy]= Up;          num=1; action=1;} 
    public void WRBCyDown()      {State[WRBCy]= Down;        num=1; action=1;}

    public void SpSupClamp()     {State[SpSup]= Clamp;       num=2; action=1;}
    public void SpSupUnClamp()   {State[SpSup]= UnClamp;     num=2; action=1;}
    
    public void WRChClamp()      {State[WRCh]= Clamp;        num=3; action=1;}
    public void WRChUnClamp()    {State[WRCh]= UnClamp;      num=3; action=1;}

    public void RCCForward()     {State[RCC]= Forward;       num=4; action=1;}
    public void RCCBackward()    {State[RCC]= Reverse;       num=4; action=1;}

    public void MomCarForward()  {State[MomCar]= Forward;    num=5; action=1;}
    public void MomCarBackward() {State[MomCar]= Reverse;    num=5; action=1;}

    public void WRCClamp()       {State[WRC]= Clamp;         num=6; action=1;}
    public void WRCUnClamp()     {State[WRC]= UnClamp;       num=6; action=1;}
    
    public void BabycarForward() {State[Babycar]= Forward;   num=7; action=1;}
    public void BabycarBackward(){State[Babycar]= Reverse;   num=7; action=1;}
    public void BabycarOut()     {State[Babycar]= 3;         num=7; action=1;}

    public void BURBCyUp()       {State[BURBCY]=Up;           num=8; action=1;}
    public void BURCBCyDown()    {State[BURBCY]=Down;         num=8; action=1;}

    public void BURCHClamp()     {State[BURCH]=Clamp;        num=9; action=1;}
    public void BURCHUnClamp()   {State[BURCH]=UnClamp;      num=9; action=1;}

    public void BURCCForward()   {State[BURCC]= Forward;     num=10; action=1;}
    public void BURCCBackward()  {State[BURCC]= Reverse;     num=10; action=1;}

    public void BURCClamp()      {State[BURC]= Clamp;        num=11; action=1;}
    public void BURCUnClamp()    {State[BURC]= UnClamp;      num=11; action=1;}


    public void WRCraneMount()    {State[WRCrane]= Mount;    num=12; action=1;}
    public void WRCraneUnMount()  {State[WRCrane]= UnMOunt;  num=12; action=1;}

    public void ZigCraneMount()   {State[ZigCrane]= Mount;   num=13; action=1;}
    public void ZigCraneUnMount() {State[ZigCrane]= UnMOunt; num=13; action=1;}

    public void BURCraneMount()   {State[BURCrane]= Mount;   num=14; action=1;}
    public void BURCraneUnMount() {State[BURCrane]= UnMOunt; num=14; action=1;}
}
