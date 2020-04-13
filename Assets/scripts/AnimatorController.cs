using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator Anim;
    public Rigidbody2D selfBody;
    [Range(0, 20)]
    public float speed;
    public Transform self;
    // Start is called before the first frame update
    void Start()
    {
        selfBody = GetComponent<Rigidbody2D>();
        self = GetComponent<Transform>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.W))
        {
            Anim.SetBool("isMove", true);
            selfBody.AddForce(Vector3.up * speed, ForceMode2D.Impulse);
        }
        else
        {
            Anim.SetBool("isMove", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Anim.SetBool("isMove", true);
            self.Translate(Vector3.right / 10);
        }
        else
        {
            Anim.SetBool("isMove", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Anim.SetBool("isMove", true);
            self.Translate(Vector3.left / 10);
        }
        else
        {
            Anim.SetBool("isMove", false);
        }
    }
}
