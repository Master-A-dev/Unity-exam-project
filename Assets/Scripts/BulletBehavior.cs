using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    [SerializeField] private float BulletSpeed = 15f;
    [SerializeField] private float DestroyTime = 3f;
    [SerializeField] private float bulletDamage = 1f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        SetStraightVelocity();

        SetDestroyTime();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collision") || collision.gameObject.CompareTag("Enemy"))
        {
            IDamagable iDamagable = collision.gameObject.GetComponent<IDamagable>();
            if (iDamagable != null)
            {
                iDamagable.Damage(bulletDamage, collision.gameObject.GetComponentInChildren<Transform>());
            }
            Destroy(gameObject);
        }
    }
    private void SetStraightVelocity()
    {
        rb.velocity = transform.right * BulletSpeed;
    }

    private void SetDestroyTime()
    {
        Destroy(gameObject, DestroyTime);
    }
}
