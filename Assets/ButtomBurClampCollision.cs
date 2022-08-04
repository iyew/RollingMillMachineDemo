using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtomBurClampCollision : MonoBehaviour
{
    public int collisionFlag;

    void Start()
    {
        collisionFlag = 0;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.name == "BackUpRollBottom")
        {
            collisionFlag = 1;
        }
    }
}
