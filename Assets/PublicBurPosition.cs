using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicBurPosition : MonoBehaviour
{

    public float Posx;
    public int PositionFlag;

    void Start()
    {
        PositionFlag = 0;
    }
    void Update()
    {
        Posx = transform.position.x;
        if(Posx < -1.0f)
        {
            PositionFlag = 1;
        }


    }
}
