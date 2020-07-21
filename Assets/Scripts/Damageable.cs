using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Damageable : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;

    public float invencibleTime = 0.1f;

    private bool canTakeDamage = true;

    public UnityEvent OnDamage;
    public UnityEvent FinishDamage;
    public UnityEvent OnDeath;

    private SpriteRenderer spriteRenderer;

    protected void Start()
    {
        currentHealth = maxHealth;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(float amount)
    {
        if (!canTakeDamage)
            return;
        canTakeDamage = false;
        currentHealth -= amount;
        OnDamage.Invoke();
        
        if(currentHealth <= 0)
        {
            OnDeath.Invoke();
            Death();
            return;
        }

        StartCoroutine(BlinkSprite());
    }

    IEnumerator BlinkSprite()
    {
        float timer = 0;
        Color defaultColor = spriteRenderer.color;
        while(timer < invencibleTime)
        {
            spriteRenderer.color = Color.clear;
            yield return new WaitForSeconds(0.05f);
            spriteRenderer.color = defaultColor;
            yield return new WaitForSeconds(0.05f);
            timer += 0.1f;
        }

        spriteRenderer.color = defaultColor;
        canTakeDamage = true;
        FinishDamage.Invoke();
    }   

    public abstract void Death();

    public void Respawn()
    {
        Debug.Log("Respawn");
        currentHealth = maxHealth;
        canTakeDamage = true;
        TakeDamage(0);
    }

}
