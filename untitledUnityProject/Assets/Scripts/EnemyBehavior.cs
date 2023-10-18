using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject player;
    public Weapon enemyWeapon;
    public float speed;
    public float distanceBetween;
    public float fireRate = 1.0f; // Adjust the fire rate here

    private float distance;
    private float lastFireTime;

    // Start is called before the first frame update
    void Start()
    {
        lastFireTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * (angle - 90));

            // Check if enough time has passed to fire again
            if (Time.time - lastFireTime >= 1.0f / fireRate)
            {
                enemyWeapon.Fire();
                lastFireTime = Time.time;
            }
        }
    }
}
