using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    public Text energyText, lifeText;
    public Image energyBar, healthBar, bossHealthBar;

    public Text[] weaponsTexts;
    public GameObject weaponPanel;
    public Transform cursor;
    private int cursorIndex;

    public bool paused;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < GameManager.instance.weapons.Count; i++)
        {
            weaponsTexts[i].text = GameManager.instance.weapons[i].weaponName;
        }
    }

    
    public void OnEnableMenu(InputValue value)
    {
        Pause();        

    }

    void Pause()
    {
        paused = !paused;

        weaponPanel.SetActive(!weaponPanel.activeSelf);

        if (paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            if (PlayerWeapon.instance.timeStopped)
            {
                Time.timeScale = 0.25f;
                
            }                
            else
                Time.timeScale = 1;
        }
    }

    public void OnSelectWeapon(InputValue value)
    {
        if (!weaponPanel.activeSelf)
            return;

        PlayerWeapon.instance.SelectWeapon(GameManager.instance.weapons[cursorIndex]);
        Pause();
    }
    public void OnUp(InputValue value)
    {
        if (!weaponPanel.activeSelf || cursorIndex <= 0)
            return;

        cursorIndex--;

        cursor.localPosition = new Vector2(cursor.localPosition.x, cursor.localPosition.y + 45);

    }
    public void OnDown(InputValue value)
    {
        if (!weaponPanel.activeSelf || cursorIndex >= GameManager.instance.weapons.Count - 1)
            return;

        cursorIndex++;

        cursor.localPosition = new Vector2(cursor.localPosition.x, cursor.localPosition.y - 45);
    }
    public void UpdateHealthBar(float health)
    {
        healthBar.fillAmount = health/10;
    }

    public void UpdateEnergyBar(float energy)
    {
        energyBar.fillAmount = energy;
    }

    public void UpdateHealthTanks(int health)
    {
        lifeText.text = "x" + health;
    }

    public void UpdateEnergyTanks(int energy)
    {
        energyText.text = "x" + energy;
    }

    public void UpdateBossHealthBar(float amount)
    {
        bossHealthBar.fillAmount = amount / 30;
    }

}
