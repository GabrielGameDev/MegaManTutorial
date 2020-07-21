using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{

    public Rigidbody2D shot;
    public Transform shotSpawn;
    public float shotSpeed = 10;
    public float fireRate = 0.15f;
    public float totalCharge = 3;
    public float chargeTime = 2;

    private float nextFire;
    private float charging = 1;
    private PlayerMovement playerMovement;
    private PlayerWeapon playerWeapon;
    private Animator animator;

    private InputAction.CallbackContext shootPhase;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerWeapon = GetComponent<PlayerWeapon>();
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shootPhase.started)
        {
            charging += Time.deltaTime * ((totalCharge - 1) / chargeTime);           
            
        }
       

        charging = Mathf.Clamp(charging, 1, totalCharge);
        
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        shootPhase = context;
        if (shootPhase.canceled)
        {           
            Shoot();
        }
    }

    public void Shoot()
    {
        if (UiManager.instance.paused)
            return;

        if (Time.time < nextFire || shot == null)
            return;

        if (playerWeapon.currentWeapon.energyAmount > 0 && playerWeapon.energy < 0)
            return;

        playerWeapon.energy -= playerWeapon.currentWeapon.energyAmount;
        UiManager.instance.UpdateEnergyBar(playerWeapon.energy);

        animator.SetTrigger("Shoot");

        nextFire = Time.time + fireRate;
        Rigidbody2D newShot = Instantiate(shot, shotSpawn.position, Quaternion.identity);
        if (playerWeapon.currentWeapon.charge)
        {
            newShot.transform.localScale *= charging;
            newShot.GetComponent<Damager>().damage *= charging;
            Debug.Log(newShot.GetComponent<Damager>().damage);
        }
            

        newShot.velocity = Vector2.right * shotSpeed * playerMovement.direction;
        charging = 1;
    }
}
