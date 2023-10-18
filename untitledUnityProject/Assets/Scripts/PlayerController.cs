using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Weapon weapon;
    public float dashCooldown = 1.0f; // Set the cooldown time for the dash
    public float dashForce = 10.0f;    // Set the force of the dash

    private float lastDashTime;

    Vector2 moveDirection;
    Vector2 mousePosition;

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        if (Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }

        // Check if the spacebar is pressed and the dash is off cooldown
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastDashTime > dashCooldown)
        {
            Dash();
        }

        Vector3 movement = new Vector3(moveX, moveY, 0f);

        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x*moveSpeed, moveDirection.y*moveSpeed);

        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }
    void Dash()
    {
        SoundManager.Instance.PlaySound(_clip);

        // Apply the dash force in the direction of movement
        rb.AddForce(moveDirection * dashForce, ForceMode2D.Impulse);

        // Update the last dash time to start cooldown
        lastDashTime = Time.time;
    }

}
