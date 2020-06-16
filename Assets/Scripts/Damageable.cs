using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Damageable : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public float invincibleTime;

    public UnityEvent OnDamage, OnFinishDamage, OnDeath;

    private bool canTakeDamage = true;

    private SpriteRenderer spriteRenderer;
    private Color defaultColor;

    // Start is called before the first frame update
    protected void Start()
    {
        currentHealth = maxHealth;
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultColor = spriteRenderer.color;
    }

    public void TakeDamage(int amount)
    {
        if (!canTakeDamage)
            return;

        canTakeDamage = false;
        currentHealth -= amount;
        OnDamage.Invoke();
        StartCoroutine(TakingDamage());
        if(currentHealth <= 0)
        {
            OnDeath.Invoke();
            Death();
        }
    }

    IEnumerator TakingDamage()
    {
        float timer = 0;
        while (timer < invincibleTime)
        {
            spriteRenderer.color = Color.clear;
            yield return new WaitForSeconds(0.05f);
            spriteRenderer.color = defaultColor;
            yield return new WaitForSeconds(0.05f);
            timer += 0.1f;
        }

        spriteRenderer.color = defaultColor;
        canTakeDamage = true;
        OnFinishDamage.Invoke();
    }

    public abstract void Death();
}
