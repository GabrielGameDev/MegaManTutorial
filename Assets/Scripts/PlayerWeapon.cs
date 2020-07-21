using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum weapon { standard, metalBlade, timeStopper }

[System.Serializable]
public class Weapon {

    public weapon weapon;
    public string weaponName;
    public Color spriteColor;
    public float energyAmount;
    public bool charge;
    public Rigidbody2D weaponShot;

}


public class PlayerWeapon : MonoBehaviour
{

    public static PlayerWeapon instance;

    public Weapon currentWeapon;    

    public float energy;

    private PlayerShoot playerShoot;
    private SpriteRenderer spriteRenderer;

    public bool timeStopped;

    private void Awake()
    {
        playerShoot = GetComponent<PlayerShoot>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        instance = this;
        SelectWeapon(GameManager.instance.weapons[0]);
    }

    void Update()
    {
         if(currentWeapon.weapon == weapon.timeStopper)
            {
                energy -= Time.deltaTime / 4f;
                UiManager.instance.UpdateEnergyBar(energy);
                if(energy <= 0)
                {
                    SelectWeapon(GameManager.instance.weapons[0]);
                }
            }
    }

    public void SelectWeapon(Weapon newWeapon)
    {
        Time.timeScale = 1;
        timeStopped = false;

        currentWeapon = newWeapon;

        playerShoot.shot = newWeapon.weaponShot;
        spriteRenderer.color = newWeapon.spriteColor;

        if(currentWeapon.weapon == weapon.timeStopper)
        {
            timeStopped = true;
            Time.timeScale = 0.25f;

        }
    }



}
