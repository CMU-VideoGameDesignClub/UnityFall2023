using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float destroyDelay = 2.0f; // Set the time in seconds after which the bullet should be destroyed.

    private void Start()
    {
        // Call the DestroyBullet method after the specified delay.
        Invoke("DestroyBullet", destroyDelay);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBullet(); // Call this method on collision as well.
    }

    private void DestroyBullet()
    {
        // Destroy the bullet game object.
        Destroy(gameObject);
    }
}