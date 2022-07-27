using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitoring : MonoBehaviour
{
    public int speedFoward = 12; // 전진속도
    public int speedSide = 6; // 옆걸음 속도

    private Transform tr; // 플레이어 트랜스폼
    private float dirX = 0;
    private float dirZ = 0;
    private float rox = 0;
    private float roz =0 ;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }

    void MovePlayer()
    {
        dirX = 0;
        dirZ = 0;

        if(OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            Vector2 coord = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

            var absX = Mathf.Abs(coord.x);
            var absY = Mathf.Abs(coord.y);

            if(absX > absY)
            {
                //right
                if(coord.x > 0)
                    dirX = +1;
                //left
                else
                    dirX = -1;
            }

            else
            {
                //up
                if(coord.y>0)
                    dirZ = +1;
                //down
                else
                    dirZ = -1;
            }

        }

        // 이동방향 설정 후 이동
        Vector3 moveDir = new Vector3(dirX*speedSide,0,dirZ*speedFoward);
        transform.Translate(moveDir * Time.smoothDeltaTime);

    }

    void RotatePlayer()
    {   
        rox = 0;
        roz = 0;

        if(OVRInput.Get(OVRInput.Touch.SecondaryThumbstick))
        {
            Vector2 coord = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);

            var absX = Mathf.Abs(coord.x);
            var absY = Mathf.Abs(coord.y);

           
            if(absX > 0)
            {
                if(coord.x > 0)
                    rox = +1;
                
                else
                    rox = -1;
            }

            var y = transform.position.y;
            Vector3 axisTransform = new Vector3(0,y,0);
            if(rox > 0)
                transform.RotateAround(tr.position,axisTransform,0.5f);
            if(rox < 0)
                transform.RotateAround(tr.position,axisTransform,-0.5f);

        }
        

        

       
        
    }
    

}
