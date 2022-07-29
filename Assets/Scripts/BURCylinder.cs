using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BURCylinder : MonoBehaviour
{
    public Transform forward, reverse;
    public Transform backUpRoll;
    private Transform target;
    private float speed;

    protected void Start()
    {
        target = transform;
        speed = 2.0f;
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

    public void Out()
    {
        backUpRoll.SetParent(this.transform);
    }

    public void In()
    {
        backUpRoll.SetParent(this.transform);
    }
}