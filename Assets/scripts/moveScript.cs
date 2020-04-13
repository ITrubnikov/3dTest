using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{

    public Transform selfTransform;
    public Vector3 targetPoint;
   
    private void Update()
    {
        selfTransform.Translate(0.1f, 0, 0, Space.Self);
        //selfTransform.Rotate(1f, 0, 1f);
        // selfTransform.position = Vector3.Lerp(selfTransform.position, targetPoint, Time.deltaTime);
       // selfTransform.position = Vector3.MoveTowards(selfTransform.position, targetPoint, 1f);
    }
}
