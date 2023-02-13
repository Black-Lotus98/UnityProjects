using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall : Ball
{
       protected override void ApplyColorToGround()
    {
        groundObject.GetComponent<Renderer>().material.color = Color.blue;
    }
}
