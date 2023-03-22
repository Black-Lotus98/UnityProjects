using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Dino : MonoBehaviour
{
    private IObjectPool<Dino> pool;
    public float currentHealth;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float timeToSelfDestruction = 3f;


    public IObjectPool<Dino> Pool { get { return this.pool; } set { this.pool = value; } }


    private void Start()
    {
        this.currentHealth = this.maxHealth;
    }

    private void OnEnable()
    {
        StartCoroutine(SelfDestruct());
    }
    private void OnDisable()
    {
        ResetDino();
    }

    private IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(timeToSelfDestruction);
        TakeDamage(maxHealth);
    }

    private void ReturnToPool()
    {
        Pool.Release(this);
    }
    private void ResetDino()
    {
        this.currentHealth = this.maxHealth;
    }
    private void TakeDamage(float amount)
    {
        this.currentHealth -=  amount;
        if(currentHealth <=0f)
        {
            ReturnToPool();
        }
    }
}


