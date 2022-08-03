using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chock : MonoBehaviour
{
    public Transform clamp, unclamp;
    private Transform target;
    private float speed;

    protected void Start()
    {
        target = transform;
        speed = 0.1f;
    }

    protected void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
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
