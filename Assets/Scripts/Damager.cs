using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{

    public float damage;

    public bool destroyOnDamage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Damageable damageable = other.GetComponent<Damageable>();
        if(damageable != null)
        {
            DoDamage(damageable);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Damageable damageable = other.gameObject.GetComponent<Damageable>();
        if (damageable != null)
        {
            DoDamage(damageable);
        }
    }

    void DoDamage(Damageable damageable)    
    {
        
        damageable.TakeDamage(damage);
        if (destroyOnDamage)
            Destroy(gameObject);
       
    }

}
