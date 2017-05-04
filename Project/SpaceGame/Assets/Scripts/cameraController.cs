using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{

    public Transform Target;
    public Transform UpperLimit;
    public Transform LowerLimit;
    Vector3 velocity = Vector3.zero;

    private void Start()
    {

    }

    private void Update()
    {
        Vector3 targetPos = transform.position;

        if (Target.position.y >= UpperLimit.position.y)
        {
            targetPos.y = Target.position.y - (UpperLimit.position.y - transform.position.y);
        }
        else if (Target.position.y <= LowerLimit.position.y)
        {
            targetPos.y = Target.position.y + (transform.position.y - LowerLimit.position.y);
        }

        if (Target.position.x >= UpperLimit.position.x)
        {
            targetPos.x = Target.position.x - (UpperLimit.position.x - transform.position.x);
        }
        else if (Target.position.x <= LowerLimit.position.x)
        {
            targetPos.x = Target.position.x + (transform.position.x - LowerLimit.position.x);
        }

        transform.position = targetPos;
    }
}
