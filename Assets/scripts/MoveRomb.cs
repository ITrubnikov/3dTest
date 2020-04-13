using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRomb : MonoBehaviour
{
    public Vector3[] Points;
    public Transform Self;

    private int _current;

    private void Start()
    {
        Self = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Self.position = Vector3.MoveTowards(Self.position, Points[_current], Time.deltaTime*3) ;

        if(Self.position == Points[_current])
        {
            if(++_current >= Points.Length)
            {
                _current = 0;
            }
        }
        
    }
}
