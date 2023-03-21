using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Torch Controller")]
public class TorchController : ScriptableObject
{

    [SerializeField] public float battery = 100;
    [SerializeField] private float multiplier = 1;
    private bool powered = true;

    public bool Powered
    {
        get {return this.powered;}
    }

    public void PassTime(float amount)
    {
        if (powered || battery > 0)
        {
            powered = true;
            battery -= amount * multiplier;
            if (battery <= 0)
            {
                powered = false;
            }
        }
    }

    void Start()
    {
        battery = 100;
        Debug.Log("Started");
        ///THIS NEVER RUNSSSS?? Why?
    }
}
