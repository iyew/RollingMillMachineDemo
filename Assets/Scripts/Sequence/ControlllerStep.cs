using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlllerStep : MonoBehaviour
{
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

    public int[] MenuState = new int[8];

    void Start(){
        for(int i = 0; i<8; i++) MenuState[i]=2;
    }

    public void RFCyUp()  {MenuState[RFCy]= Up;}
    public void RFCyDown(){MenuState[RFCy]= Down;}

    public void WRBCyUp()  {MenuState[WRBCy]= Up;}
    public void WRBCyDown(){MenuState[WRBCy]= Down;}

    public void SpSupClamp()  {MenuState[SpSup]= Clamp;}
    public void SpSupUnClamp(){MenuState[SpSup]= UnClamp;}
    
    public void WRChClamp()   {MenuState[WRCh]= Clamp;}
    public void WRChUnClamp() {MenuState[WRCh]= UnClamp;}

    public void RCCForward()  {MenuState[RCC]= Forward;}
    public void RCCBackward() {MenuState[RCC]= Reverse;}

    public void MomCarForward() {MenuState[MomCar]= Forward;}
    public void MomCarBackward(){MenuState[MomCar]= Reverse;}

    public void WRCClamp()  {MenuState[WRC]= Clamp;}
    public void WRCUnClamp(){MenuState[WRC]= UnClamp;}
    
    public void BabycarForward() {MenuState[Babycar]= Forward;}
    public void BabycarBackward(){MenuState[Babycar]= Reverse;}

}
