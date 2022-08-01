using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackUpRoll : MonoBehaviour
{
    public Transform up, down;
    private Transform target;
    public bool isBalanceDown;
    private float speed;

    protected void Start()
    {
        target = transform;
        isBalanceDown = false;
        speed = 0.05f;
    }

    protected void Update()
    {
        if (!isBalanceDown)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
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
