using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonAnimatorController : MonoBehaviour
{
    public Animator Animator;
    public Transform EndPoint;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Animator.SetTrigger("Fly");
        }

        float speed = Input.GetAxis("Horizontal");
        
        Animator.SetFloat("Speed", speed);
        transform.position = Vector3.MoveTowards(transform.position, EndPoint.position, Time.deltaTime);
    }
    
    
}
