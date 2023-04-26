using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Monster
{
    private int health;
    private int speed;


    private static int skeletonCounter = 0;

    public Skeleton(int health, int speed, GameObject monsterPrefab)
    {
        this.health = health;
        this.speed = speed;
        this.model = monsterPrefab;

        skeletonCounter += 1;
    }

    public override Monster Clone()
    {
        return new Skeleton(health, speed, model);
    }

    public override void Talk()
    {
        Debug.Log($"Hello this is skeleton number {skeletonCounter}. My health is {health} and my speed is {speed}");
    }
}
