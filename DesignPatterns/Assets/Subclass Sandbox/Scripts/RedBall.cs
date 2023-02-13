using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : Ball
{
    protected override void ApplyColorToGround()
    {
        groundObject.GetComponent<Renderer>().material.color = Color.red;
    }
}