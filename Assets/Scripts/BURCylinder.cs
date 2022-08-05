using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BURCylinder : MonoBehaviour
{
    public Transform forward, reverse, _out;
    public Transform backUpRollBottom;
    private Transform target;
    private float speed;
    public int flag;
    public Rigidbody burCylinder;
    public float power;
    public int collisionFlag;
    public GameObject cylinderChildren;

    protected void Start()
    {
        target = transform;
        speed = 1.5f;
        flag = 0;
        power = 5;
        collisionFlag = 0;
    }

    protected void Update()
    {
        float step = speed * Time.deltaTime;
        var x1 = burCylinder.transform.localPosition.x;
        var y2 = burCylinder.transform.localPosition.y;
        var z2 = burCylinder.transform.localPosition.z;
        var posX = burCylinder.transform.position.x;
        collisionFlag = cylinderChildren.GetComponent<ButtomBurClampCollision>().collisionFlag;
        

        if(flag == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            flag = 0;
        }

        else if(flag == 2)
        {
            burCylinder.AddForce(Vector3.right*power,ForceMode.Acceleration);
            if( posX > forward.transform.position.x)
            {
                burCylinder.velocity = Vector3.zero;
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
        backUpRollBottom.SetParent(this.transform);
        //backUpRollBottom.GetComponent<BackUpRoll>().isBalanceDown = true;
        }    
    }

    public void UnClamp()
    {
        backUpRollBottom.SetParent(null);
        //backUpRollBottom.GetComponent<BackUpRoll>().isBalanceDown = true;
    }
}
