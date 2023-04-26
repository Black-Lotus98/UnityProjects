using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spirit : Monster
{
    private int health;
    private int speed;
    public Spirit(int health, int speed, GameObject monsterPrefab)
    {
        this.health = health;
        this.speed = speed;
        this.model = monsterPrefab;

        spiritCounter += 1;
    }

    private static int spiritCounter = 0;
    public override Monster Clone()
    {
        return new Spirit(health, speed, model);
    }

    public override void Talk()
    {
        Debug.Log($"Hello this is Demon number {spiritCounter}. My health is {health} and my speed is {speed}");
    }
}
