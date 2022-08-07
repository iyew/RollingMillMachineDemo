using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChckTrigger : MonoBehaviour
{
    public int chockflag;

    void Start()
    {
        chockflag = -1;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.name == "chockTrigger")
        {
            chockflag *= -1;
        }
    }
}
