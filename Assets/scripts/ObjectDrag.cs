using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrag : MonoBehaviour
{
    
    public Rigidbody  Body;
[Range(0,10)]
    public float  ZOffSet;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Body = GetComponent<Rigidbody>(); 

    }

    // Update is called once per frame
    void Update()
    {
        transform.position =
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, ZOffSet));

    }
}
