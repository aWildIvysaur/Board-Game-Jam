using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float hInput;
    public float vInput;
    public float angle;
    private Vector3 direction = new Vector3(0,0,0);

    public float speed;

    // Update is called once per frame
    void Update()
    {
        #region Movement
            hInput = Input.GetAxis("Horizontal");
            vInput = Input.GetAxis("Vertical");
    
            direction.x = Time.deltaTime * speed * hInput;
            direction.z = Time.deltaTime * speed * vInput;
    
            transform.Translate(direction, Space.World);
        #endregion

        #region Rotation
        if (hInput != 0 || vInput != 0)
            {
                if (vInput != 0)
                {
                    angle = (float)Math.Atan(hInput / vInput) * 180 / (float)Math.PI;
                }
                else if(hInput == 0)
                {
                    if (vInput > 0)
                        {angle  = 0;}
                    else if (vInput < 0)
                        {angle = 180;}
                }
                
                    {transform.eulerAngles = new Vector3(0, angle, 0);}
            }
        #endregion
        
    }
}
