using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerItems : MonoBehaviour
{
    public int healthTanks;
    public int energyTanks;

    PlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    public void OnHealthUsed(InputAction.CallbackContext ctx)
    {
        if (healthTanks <= 0)
        {
            return;
        }

        healthTanks--;
        UpdateLifeTanks(healthTanks);
        UpdateHealthBar();
    }
    public void OnEnergyUsed(InputAction.CallbackContext ctx)
    {
        if(energyTanks <= 0)
        {
            return;
        }
        energyTanks--;
        UpdateEnergyTanks(energyTanks);
        UpdateEnergyBar();
    }

    public void UpdateLifeTanks(int amount)
    {
        healthTanks = amount;
        UiManager.instance.UpdateHealthTanks(healthTanks);
    }

    public void UpdateEnergyTanks(int amount)
    {
        energyTanks = amount;
        UiManager.instance.UpdateEnergyTanks(energyTanks);
    }

    void UpdateEnergyBar()
    {
        FindObjectOfType<PlayerWeapon>().energy = 1;
        UiManager.instance.UpdateEnergyBar(1);
    }

    void UpdateHealthBar()
    {
        UiManager.instance.UpdateHealthBar(10);
        playerHealth.currentHealth = playerHealth.maxHealth;
    }

}
