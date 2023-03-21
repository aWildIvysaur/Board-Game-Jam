using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    [SerializeField] private TorchController controller;
    [SerializeField] private Texture Battery5;
    [SerializeField] private Texture Battery4;
    [SerializeField] private Texture Battery3;
    [SerializeField] private Texture Battery2;
    [SerializeField] private Texture Battery1;
    [SerializeField] private Texture Battery0;
    public RawImage self;

    private Texture[] textures;

    private int currentTexture = 5;


    // Start is called before the first frame update
    void Start()
    {
        textures  = new Texture[] {Battery0, Battery1, Battery2, Battery3, Battery4, Battery5};
        controller.battery = 100;
    }

    // Update is called once per frame
    void Update()
    {
        controller.PassTime(Time.deltaTime);
        if (controller.Powered)
        {
            if (controller.battery > 80)
            {
                currentTexture = 5;
            }
            else if (controller.battery > 60)
            {
                currentTexture = 4;
            }
            else if (controller.battery > 40)
            {
                currentTexture = 3;
            }
            else if (controller.battery > 20)
            {
                currentTexture = 2;
            }
            else if (controller.battery > 0)
            {
                currentTexture = 1;
            }
        }
        else
        {
            currentTexture = 0;
        }

        this.GetComponent<RawImage>().texture = textures[currentTexture];
    }
}
