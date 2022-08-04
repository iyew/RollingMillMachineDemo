using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyCar : MonoBehaviour
{
    public Transform forward, reverse, _out;
    public Transform workRollTop, workRollBottom;
    private Transform target;
    private float speed;
    public int flag;
    public Rigidbody babyCar;
    public float power;
    public int collisionFlag;

    protected void Start()
    {
        target = transform;
        speed = 1.5f;
        flag = 0;
        power = 1;
        collisionFlag = 0;
    }

    protected void Update()
    {
        
        float step = speed * Time.deltaTime;
        var x1 = babyCar.transform.localPosition.x;
        var y2 = babyCar.transform.localPosition.y;
        var z2 = babyCar.transform.localPosition.z;
        var posX = babyCar.transform.position.x;
        

        if(flag == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            flag = 0;
        }

        else if(flag == 2)
        {
            babyCar.AddForce(Vector3.right*power);
            if( posX > forward.transform.position.x)
            {
                babyCar.velocity = Vector3.zero;
            }
            
        }   
    }

    public void Forward()
    {
        flag = 2;
    }

    public void Reverse()
    {
        target = reverse;
        flag = 1;
    }

    public void Stop()
    {
        target = this.transform;
        flag = 1;
    }

    public void Out()
    {
        target = _out;
        flag = 1;
    }

    public void Clamp()
    {   
        if(collisionFlag == 1)
        {
        workRollTop.SetParent(this.transform);
        workRollBottom.SetParent(this.transform);
        workRollTop.GetComponent<WorkRoll>().isBalanceDown = true;
        workRollBottom.GetComponent<WorkRoll>().isBalanceDown = true;
        }
    }

    public void UnClamp()
    {
        workRollTop.SetParent(null);
        workRollBottom.SetParent(null);
        workRollTop.GetComponent<WorkRoll>().isBalanceDown = true;
        workRollBottom.GetComponent<WorkRoll>().isBalanceDown = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.name == "roll-s:1")
        {
            collisionFlag = 1;
        }
    }
}
