using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalMan : MonoBehaviour
{
    public Vector2 jumpForce;
    public GameObject bullet;
    public Transform shotSpawn;
    public float fireRate = 1;
    public float jumpInterval = 3;
    public LayerMask groundLayer;
    public Transform player;
    public RollingPlatform rollingPlatform;

    private float nextJump;
    private float nextFire;
    private Rigidbody2D rb;

    
    private bool onGround;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("SwithPlatformDirection", 10, 10);
    }

    public void StartBossFight()
    {
        
    }

    private void FixedUpdate()
    {
        AimingPlayer();

        if(Time.time > nextJump)
        {
            Jump();
        }

        onGround = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 3, groundLayer);
        Color color = hit ? Color.red : Color.green;
        Debug.DrawRay(transform.position, Vector2.down * 1, color);
        onGround = hit;

        if (!onGround && Time.time > nextFire)
        {
            Shoot();
        }

    }

    void Jump()
    {
        nextJump = Time.time + jumpInterval;
        rb.AddForce(Vector2.up * Random.Range(jumpForce.x, jumpForce.y), ForceMode2D.Impulse);
    }

    void Shoot()
    {
        nextFire = Time.time + fireRate;
        Instantiate(bullet, shotSpawn.position, shotSpawn.rotation);
    }

    void AimingPlayer()
    {
        Vector2 direction = player.position - shotSpawn.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        shotSpawn.rotation = rotation;
    }

    void SwithPlatformDirection()
    {
        rollingPlatform.direction *= -1;
    }
}
