using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHack : MonoBehaviour
{
    public Transform SelfTrasform;

    private void Start()
    {
        SelfTrasform = GetComponent<Transform>(); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            SelfTrasform.parent = collision.transform;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            SelfTrasform.parent = null;
        }
    }
}
