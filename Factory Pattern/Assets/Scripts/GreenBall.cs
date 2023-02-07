using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : Ball
{
    public override string BallColor => "GreenBall";
    // public override string BallColor { get { return "GreenBall"; } }
    public override void CreateBall()
    {
        Debug.Log("Create Green Ball");
    }
}
