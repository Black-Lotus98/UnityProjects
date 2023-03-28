using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public MovementManager movementManager;

     private void OnGUI()
    {
        if (GUILayout.Button("Save"))
        {
            movementManager.SaveGame();
        }

        if (movementManager.isDirty)
        {
            GUILayout.Box("Warning: you have unsaved changes");
        }
    }
}
