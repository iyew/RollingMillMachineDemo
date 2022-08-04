using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackUpRoll : MonoBehaviour
{
    public Transform up, down;
    private Transform target;
    public bool isBalanceDown;
    private float speed;
    public int x;
    public int topBurFlag;
    public GameObject topBur;

    void Start()
    {
        target = transform;
        isBalanceDown = false;
        speed = 0.05f;
        x = 0;
        topBurFlag = 0;
    }

    void Update()
    {
        topBurFlag = topBur.GetComponent<TopBurCollider>().y;
        
        if(topBurFlag == 1)
        {
            x = 2;
        }

        
    }

    public void Up()
    {
        target = up;
    }

    public void Down()
    {
        //target = down;
        x = 1;
    }
}
