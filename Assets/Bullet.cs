using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public int damage = 25;
    public Rigidbody2D rb;


    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);

        BossFight boss = hitInfo.GetComponent<BossFight>();
        if (boss != null)
        {
            boss.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
