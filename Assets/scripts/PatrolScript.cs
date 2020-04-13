using UnityEngine;
using System.Collections;

public class PatrolScript: MonoBehaviour
{

    public Transform Self;
    public Vector3 Target;
    public float speed;

    bool changeVector;
    Rigidbody2D rigidbody;
    
    // Use this for initialization
    void Start()
    {
        rigidbody.AddForce(new Vector2(10, 0));
        Self = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //rigidbody.AddForce(new Vector2(changeSpeed(), 0));
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Wall")
        {
            changeSpeed();
            Self.position = Vector3.Lerp(Self.position, Self.position + Target, Time.deltaTime * speed);
        }
    }
    private void changeSpeed()
    {
        this.changeVector = !changeVector;
        int sideSpeed;
        if (changeVector)
        {
            Target = Vector3.left;
        }
        else
        {
            Target = Vector3.right;
        }
       
       
    }
}
