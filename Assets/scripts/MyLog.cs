using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLog : MonoBehaviour
{

    private void OnMouseDown()
    {
        Debug.Log("Down: " + gameObject.name);
    }

    private void OnMouseEnter()
    {
        Debug.Log("Enter: " + gameObject.name);
    }

    private void OnMouseOver()
    {
        Debug.Log("Over: " + gameObject.name);
    }

}
