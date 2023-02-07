using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : Ball
{
    public override string BallColor => "RedBall";

    public override void CreateBall()
    {
        Debug.Log("Create Red Ball");
    }
}
