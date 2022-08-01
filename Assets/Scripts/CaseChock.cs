using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseChock : MonoBehaviour
{
    public Transform up, down;
    private Transform target;
    private float speed;

    protected void Start()
    {
        target = transform;
        speed = 0.05f;
    }

    protected void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    public void Up()
    {
        target = up;
    }

    public void Down()
    {
        target = down;
    }
}
