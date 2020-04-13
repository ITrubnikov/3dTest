using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My1Script : MonoBehaviour
{ 
    private void Awake()
    {
        Debug.Log("Awake: " + gameObject.name);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update: " + gameObject.name);
    }
}
