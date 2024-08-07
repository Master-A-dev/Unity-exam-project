using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D bc;
        bc = gameObject.AddComponent<BoxCollider2D>();
        bc.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            charSheet.player.hp--;
        }
            
    }
}
