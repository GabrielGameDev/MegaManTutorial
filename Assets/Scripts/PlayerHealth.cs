using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Damageable
{

    private int defaultLayer;

    public override void Death()
    {
        Debug.Log("Morreu");
    }

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        defaultLayer = gameObject.layer;
    }

    public void SetInvincible(bool state)
    {
        if (state)
        {
            gameObject.layer = LayerMask.NameToLayer("Invencible");
        }
        else
        {
            gameObject.layer = defaultLayer;
        }
    }
}
