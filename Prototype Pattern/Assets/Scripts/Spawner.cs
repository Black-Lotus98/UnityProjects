using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Monster prototype;

    public Spawner(Monster prototype)
    {
        this.prototype = prototype;
    }

    public Monster SpawnMonster()
    {
        return prototype.Clone();
    }
}
