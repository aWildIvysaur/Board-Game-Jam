using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FollowPlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float deadzoneRadius;
    private Vector3 difference;
    private bool moving = false;
    [SerializeField] private float speed;
    private Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        difference = transform.position - offset - target.position;
        temp = new Vector3(0, 0, difference.z);
        transform.position -= temp;


        if (Math.Abs(difference.x) > deadzoneRadius)
        {
            moving = true;
        }

        if (moving)
        {
            if (Math.Abs(difference.x) > 0.2)
            {
                speed = difference.x;
                if (Math.Abs(difference.x) > 7)
                {
                    Debug.Log("boosted");
                    if (difference.x > 0)
                    {
                        speed += 7;
                    }
                    else
                    {
                        speed -= 7;
                    }
                }
                transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
            }
            else
            {
                transform.position -= new Vector3(difference.x, 0, 0);
                moving = false;
            }

        }
    }
}
