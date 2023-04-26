using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monster
{
    //This method implements the Prototype design pattern
    public GameObject model;

    public abstract Monster Clone();
    public abstract void Talk();
}
