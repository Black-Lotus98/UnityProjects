using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : DirtyFlag
{

    public Transform player;
    public float playerSpeed;
    private Vector3 savedPos;

    private void Awake()
    {
        savedPos = player.position;
        isDirty = false;
    }

    public void MovePlayer(Vector3 direction)
    {
        player.Translate(playerSpeed * Time.deltaTime * direction);
        isDirty = true;
    }

    public override void SaveGame()
    {
        // perform the save game action
        isDirty = false;
        Debug.Log($"Game is saved");

    }
}
