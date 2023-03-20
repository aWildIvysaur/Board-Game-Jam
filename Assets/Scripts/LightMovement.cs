using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovement : MonoBehaviour
{

    private float hInput;
    private float vInput;
    [SerializeField] private float hMultiplier;
    [SerializeField] private float vMultiplier;
    private Vector3 rotation = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Mouse X");
        vInput = Input.GetAxis("Mouse Y");
        rotation += new Vector3(vInput * -1 * vMultiplier, hInput * hMultiplier, 0);
        transform.eulerAngles = rotation;
    }
}
