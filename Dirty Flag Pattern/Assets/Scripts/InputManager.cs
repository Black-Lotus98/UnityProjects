using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public MovementManager movementManager;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { movementManager.MovePlayer(Vector3.forward); }
        if (Input.GetKey(KeyCode.S)) { movementManager.MovePlayer(Vector3.back); }
        if (Input.GetKey(KeyCode.A)) { movementManager.MovePlayer(Vector3.left); }
        if (Input.GetKey(KeyCode.D)) { movementManager.MovePlayer(Vector3.right); }
    }
}
