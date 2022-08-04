using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForcrCylinder : MonoBehaviour
{

    public GameObject topBur;
    public Rigidbody rollForceCylinder;
    void Update()
    {
        var flag = topBur.GetComponent<BackUpRoll>().x;
        var x = transform.localPosition.x;
        var y = transform.localPosition.y;
        var z = transform.localPosition.z;
        if(flag == 1)
        {
            transform.localPosition = new Vector3(x,y,z-Time.deltaTime);
        }

        else if(flag == 2)
        {
           // transform.localPosition = new Vector3(x,y,z);
        }

    }
}
