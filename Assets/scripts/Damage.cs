using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{
    public Health myHealth;

    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Damagemble");

        foreach (GameObject obj in objs)
        {
            Health hp = obj.GetComponent<Health>();
            hp.TakeDamage(1);
        }



        //if (myHealth)
        //{
        //    myHealth.TakeDamage(1);
        //}

    }
}
