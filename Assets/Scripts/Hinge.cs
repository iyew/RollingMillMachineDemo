using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinge : MonoBehaviour
{
    public Transform clamp, unclamp;
    private Transform target;
    private float speed;

    protected void Start()
    {
        target = transform;
        speed = 50.0f;
    }

    protected void Update()
    {
        float step = speed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
    }

    public void Clamp()
    {
        target = clamp;
    }

    public void UnClamp()
    {
        target = unclamp;
    }
}
