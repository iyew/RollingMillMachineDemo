using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPosition : MonoBehaviour
{
    public GameObject machineController;
    float[,] position;

    void Start(){
        position = new float[29, 3]{
        {0.00100000005f,0.880400002f, 0.58039999f},  //Lamp Test
        {-0.0579999983f,0.879499972f, 0.562399983f}, //RollForceCylinder Down
        {0.0917999968f, 0.885200024f, 0.672599971f}, //W/R Balance   Down
        {-0.165999994f, 0.879400015f, 0.562300026f}, //SpSu     Clamp
        {0.168400005f,  0.885200024f, 0.672599971f}, //WRCh      UnClamp
        {-0.107100002f, 0.870100021f, 0.38440001f},  //RCC      Forward
        {-0.0412000008f,0.870100021f, 0.383700013f}, //MomCar   Forward
        {0.0909999982f, 0.882300019f, 0.617900014f}, //WRC      UnClamp
        {0.0760999992f, 0.870100021f, 0.384499997f}, //BabyCar  ForWard
        {0.0617999993f, 0.882300019f, 0.617900014f}, //WRC      Clamp
        {0.0463000014f, 0.870100021f, 0.384499997f}, //BabyCar  Reverse
        {-0.0742999986f,0.870100021f, 0.383700013f}, //MomCar  Reverse
        {-0.134000003f, 0.870100021f, 0.38440001f},  //RCC    Reverce
        {0.0909999982f, 0.882300019f, 0.617900014f}, //WRC      UnClamp
        {0.0419000015f, 0.869300008f, 0.368699998f}, //BabyCar  Out
        {-0.165199995f, 0.888000011f, 0.726499975f}, //WRCrane  Mount
        {0.164100006f,  0.888599992f, 0.737399995f}, //BURCh    Unclamp
        {-0.107100002f, 0.870100021f, 0.38440001f},  //RCC      Forward
        {0.0173000004f, 0.870100021f, 0.383700013f}, //BURCC    Forward
        {0.132699996f,  0.882300019f, 0.617900014f}, //BURC     Clamp
        {-0.0142999999f,0.870100021f, 0.384200007f}, //BURCC    Reverse
        {-0.134000003f, 0.870100021f, 0.38440001f},  //RCC    Reverce
        {-0.0165999997f,0.888000011f, 0.726499975f}, //ZigCrane   Mount
        {-0.107100002f, 0.870100021f, 0.38440001f},  //RCC      Forward
        {0.0173000004f, 0.870100021f, 0.383700013f}, //BURCC    Forward
        {0.0917999968f, 0.888000011f, 0.726300001f}, //BURBCy   DOWN
        {-0.0142999999f,0.870100021f, 0.384200007f}, //BURCC    Reverse
        {-0.134000003f, 0.870100021f, 0.38440001f},  //RCC    Reverce
        {-0.0914999992f,0.888000011f,0.726499975f}   //BURCrane  Mount
        };
    }
    void Update()
    {
        int i = machineController.GetComponent<Mode>().step;
        if(i<29){
            Vector3 destination = new Vector3(position[i,0], position[i,1], position[i,2]);
            transform.position = Vector3.MoveTowards(transform.position, destination, 1);
        }
    }
}
