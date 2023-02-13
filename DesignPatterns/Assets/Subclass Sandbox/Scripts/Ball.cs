using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ball : MonoBehaviour
{
    protected abstract void ApplyColorToGround();
    protected GameObject groundObject;
    private void Start()
    {
        groundObject = GameObject.FindGameObjectWithTag("Ground");
    }

    private void OnCollisionEnter(Collision other)
    {
        ApplyColorToGround();
    }

}
