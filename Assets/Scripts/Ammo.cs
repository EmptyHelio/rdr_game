using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float destroyTime;
    public int damage = 1;


    void Start()
    {
        rb.velocity = transform.right * speed;
        Invoke("DestroyAmmo", destroyTime);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            
        }
        Destroy(gameObject);
    }

    void DestroyAmmo()
    {
        Destroy(gameObject);
    }
}
