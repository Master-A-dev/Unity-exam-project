using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyGeneral : MonoBehaviour, IDamagable
{

    [SerializeField] private float maxHealth = 5f;
    [SerializeField] private GameObject DeadBody;
    [SerializeField] private Transform DeadBodySpawnpoint;

    private GameObject DeadBodyInst;

    private float currentHealth;
    

    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void Damage(float damageAmount, Transform target)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0) 
        {
           
            DeadBodyInst = Instantiate(DeadBody, target.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
