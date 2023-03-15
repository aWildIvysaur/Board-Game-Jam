using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{
    public Transform target;
    public Transform self;
    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        //layermask |= (1 << 6);
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Linecast(self.position, target.position, out hit))
        {
            Debug.DrawLine(self.position, hit.point, Color.red);
        }
        else
        {
            Debug.DrawLine(self.position, target.position, Color.green);
        }
    }
}
