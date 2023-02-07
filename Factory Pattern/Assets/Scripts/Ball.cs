using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ball : MonoBehaviour
{
    public abstract string BallColor { get; }
    public abstract void CreateBall();

}
