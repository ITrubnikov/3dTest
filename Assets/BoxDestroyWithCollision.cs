using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoxDestroyWithCollision : MonoBehaviour
{
   public UnityEvent OnDestroy;


   private void OnCollisionEnter2D(Collision2D other)
   {
      Debug.Log("BAMMMMM!!!!");
      OnDestroy.Invoke();
      Destroy(gameObject, 1 );
   }
}
