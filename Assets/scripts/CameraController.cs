using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform self;
    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            self.Translate(Vector3.left);
        }
        if (Input.GetKey(KeyCode.A))
        {
            self.Translate(Vector3.right);
        }

    }
}
