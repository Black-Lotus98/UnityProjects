using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class DinoObjectPool : MonoBehaviour
{

    public int maxPoolSize = 20;
    public int stackDefaultCapacity = 20;
    public IObjectPool<Dino> pool;

    public GameObject myPrefab;


    public IObjectPool<Dino> Pool
    {
        get
        {
            if (pool == null)
            {
                pool = new ObjectPool<Dino>(CreatedPooledItem,
                                            OnTakeFromPool,
                                            OnReturnedToPool,
                                            OnDestroyPoolObject,
                                            true,
                                            stackDefaultCapacity,
                                            maxPoolSize);
            }
            return this.pool;
        }
    }

    private Dino CreatedPooledItem()
    {
        GameObject gameObject = Instantiate(Resources.Load("Raptor", typeof(GameObject))) as GameObject;

        Dino dino = gameObject.AddComponent<Dino>();
        gameObject.name = "Dino";
        dino.Pool = Pool;
        return dino;
    }

    private void OnReturnedToPool(Dino dino)
    {
        dino.gameObject.SetActive(false);
    }
    private void OnTakeFromPool(Dino dino)
    {
        dino.gameObject.SetActive(true);
    }
    private void OnDestroyPoolObject(Dino dino)
    {
        Destroy(dino.gameObject);
    }

    public void Spawn()
    {
        var amount = Random.Range(1, 10);
        for (int i = 0; i < amount; i++)
        {
            var dino = Pool.Get();
            dino.transform.position = Random.insideUnitSphere * 10;
        }
    }
}
