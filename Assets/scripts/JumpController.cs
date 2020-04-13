using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    public Rigidbody2D selfBody;
    [Range(0, 20)]
    private float speed;
    public Transform self;

    // Start is called before the first frame update
    void Start()
    {
        selfBody = GetComponent<Rigidbody2D>();
        self = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            selfBody.AddForce(Vector3.up * speed, ForceMode2D.Impulse); 
        }
        if (Input.GetKey(KeyCode.D))
        {
            self.Translate(Vector3.right /10);
        }
        if (Input.GetKey(KeyCode.A))
        {
            self.Translate(Vector3.left /10);
        }
    }
}
