using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Transform forward, reverse;
    private Transform target;
    private float speed;

    protected void Start()
    {
        target = transform;
        speed = 1.5f;
    }

    protected void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    public void Forward()
    {
        target = forward;
    }

    public void Reverse()
    {
        target = reverse;
    }

    public void Stop()
    {
        target = this.transform;
    }
}
