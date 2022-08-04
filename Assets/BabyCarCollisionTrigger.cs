using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyCarCollisionTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public int collisionFlag;

    void Start()
    {
        collisionFlag = 0;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.name == "roll-s:1")
        {
            collisionFlag = 1;
        }
    }
}
