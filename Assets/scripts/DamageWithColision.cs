using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageWithColision : MonoBehaviour
{

    public Health myHelth;
    // Start is called before the first frame update
    void Start()
    {
        myHelth = GetComponent<Health>();
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        myHelth.TakeDamage(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
