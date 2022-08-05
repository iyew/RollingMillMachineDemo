using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackUpRollButtom : MonoBehaviour
{
    public Transform up, down;
    private Transform target;
    private float speed;
    private bool isCylinderDown;

    protected void Start()
    {
        target = transform;
        speed = 0.1f;
        isCylinderDown = false;
    }

    protected void Update()
    {
        if (!isCylinderDown)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    public void Up()
    {
        target = up;
        Invoke("CylinderUp", 1);
    }

    public void Down()
    {
        target = down;
        Invoke("CylinderDown", 1);
    }

    public void CylinderUp()
    {
        isCylinderDown = false;        
    }


    public void CylinderDown()
    {
        isCylinderDown = true;
    }
}
