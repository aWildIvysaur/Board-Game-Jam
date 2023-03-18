using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerMovement : MonoBehaviour
{
    public float speed;
    public Transform target;
    public Transform self;
    private Vector3 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Physics.Linecast(self.position, target.position, (1 << 0)))
        {
            targetPos = target.position;
            targetPos.y = self.position.y;
            self.position = Vector3.MoveTowards(self.position, targetPos, speed * Time.deltaTime);
            Debug.DrawLine(self.position, target.position, Color.green);
        }
        else
        {
            Debug.DrawLine(self.position, target.position, Color.red);
        }

    }
}
