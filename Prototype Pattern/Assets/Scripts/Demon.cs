using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : Monster
{
    // [SerializeField] GameObject demonModel;
    private int health;
    private int speed;

    private static int demonCounter = 0;

    public Demon(int health, int speed, GameObject monsterPrefab)
    {
        this.health = health;
        this.speed = speed;
        this.model = monsterPrefab;

        demonCounter += 1;
    }

    public override Monster Clone()
    {
        return new Demon(health, speed, model);
    }

    public override void Talk()
    {
        Debug.Log($"Hello this is Demon number {demonCounter}. My health is {health} and my speed is {speed}");
    }
}
