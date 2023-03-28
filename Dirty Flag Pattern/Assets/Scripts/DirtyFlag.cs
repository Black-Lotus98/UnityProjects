using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DirtyFlag : MonoBehaviour
{
    public bool isDirty;

    public abstract void SaveGame();

}
