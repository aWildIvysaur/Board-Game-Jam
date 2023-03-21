using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchControls : MonoBehaviour
{
    private Light light;
    [SerializeField] TorchController controller;

    // Start is called before the first frame update
    void Start()
    {
        light = this.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.Powered)
        {
            light.range = 100;
        }
        else
        {
            light.range = 0;
        }

        if (controller.battery > 30)
        {
            light.spotAngle = 60;
        }
        else
        {
            light.spotAngle = 60 - (60 - controller.battery*2);
        }
    }
}
