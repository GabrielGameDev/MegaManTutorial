using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum item { energy, health}

public class Item : MonoBehaviour
{
    public item item;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerItems player = other.GetComponent<PlayerItems>();
        if(player != null)
        {
            if(item == item.energy)
            {
                player.UpdateEnergyTanks(1);
            }
            else if (item == item.health)
            {
                player.UpdateLifeTanks(1);
            }

            Destroy(gameObject);
        }
    }

}
