using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{

    public Rigidbody2D shot;
    public float shotSpeed = 15;
    public float fireRate = 0.15f;
    public float totalCharge = 3;
    public float totalChargeTime = 2;

    public float charging = 1;
    private float nextFire;
    private InputAction.CallbackContext shootPhase;
    private PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shootPhase.started)
        {
            charging += Time.deltaTime * ((totalCharge - 1) / totalChargeTime);
        }

        charging = Mathf.Clamp(charging, 1, totalCharge);
    }

    public void OnShoot(InputAction.CallbackContext ctx)
    {
        shootPhase = ctx;
        if (shootPhase.canceled)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (Time.time < nextFire)
            return;

        nextFire = Time.time + fireRate;
        Rigidbody2D newShot = Instantiate(shot, transform.position, Quaternion.identity);
        newShot.velocity = Vector2.right * shotSpeed * playerMovement.direction;

        newShot.transform.localScale *= charging;
        charging = 1;
    }
}
