using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BallFactory : MonoBehaviour
{
    public Ball GetBall(string ballColor)
    {
        switch (ballColor)
        {
            case "GreenBall":
                return new GreenBall();
            case "RedBall":
                return new RedBall();
            default:
                return null;
        }
    }
}
