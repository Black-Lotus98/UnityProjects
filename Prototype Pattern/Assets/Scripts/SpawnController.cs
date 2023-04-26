using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    private Demon demonPrototype;
    private Skeleton skeletonPrototype;
    private Spirit spiritPrototype;

    [SerializeField] private GameObject demonPrefab;
    [SerializeField] private GameObject skeletonPrefab;
    [SerializeField] private GameObject spiritPrefab;

    void Start()
    {
        demonPrototype = new Demon(11, 7, demonPrefab);
        skeletonPrototype = new Skeleton(15, 3, skeletonPrefab);
        spiritPrototype = new Spirit(50, 20, spiritPrefab);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Spawner demonSpawner = new Spawner(demonPrototype);
            Demon newDemon = demonSpawner.SpawnMonster() as Demon;
            newDemon.Talk();
            // Instantiate the associated GameObject
            Instantiate(newDemon.model, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Spawner skeletonSpawner = new Spawner(skeletonPrototype);
            Skeleton newSkeleton = skeletonSpawner.SpawnMonster() as Skeleton;
            newSkeleton.Talk();

            Instantiate(newSkeleton.model, transform.position + new Vector3(5, 5, 5), Quaternion.identity);

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Spawner spiritSpawner = new Spawner(spiritPrototype);
            Spirit newSpirit = spiritSpawner.SpawnMonster() as Spirit;
            newSpirit.Talk();

            Instantiate(newSpirit.model, transform.position + new Vector3(-5, 5, -5), Quaternion.identity);
        }
    }
}
