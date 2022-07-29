using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneYscale : MonoBehaviour
{
    public GameObject cylinder;
    void Update()
    {
        var x = cylinder.transform.localPosition.x;
        var z= cylinder.transform.localPosition.z;
        var y= cylinder.transform.localPosition.y;
        cylinder.transform.localPosition = new Vector3(x,y,z+0.01f);
    }
}
