using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ball2 : MonoBehaviour
{
   protected GameObject groundObject;
   protected abstract void ApplyColorToGround();

   private void Start()
   {
    groundObject = GameObject.FindGameObjectWithTag("Ground");
   }


    private void OnCollisionEnter(Collision other)
    {
        ApplyColorToGround();
    }

}
