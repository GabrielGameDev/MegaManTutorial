using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public string levelSelected;
    public int boss;

    public List<Weapon> weapons;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void AddWeapon(Weapon newWeapon)
    {
        for (int i = 0; i < weapons.Count; i++)
        {
            if (weapons[i].weapon == newWeapon.weapon)
                return;
        }

        weapons.Add(newWeapon);
    }

}
