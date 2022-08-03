using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopBurCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject topBur;
    public Transform zig;
   void OnTriggerEnter(Collider other)
   {
    if(other.name == "ZIG")
    {
        topBur.transform.SetParent(zig);
    }
   }
}
