using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Damageable
{
    private int defaultLayer;

    private void Start()
    {
        base.Start();
        defaultLayer = gameObject.layer;
    }

    public override void Death()
    {
        if (LevelManager.instance.checkPoint)
        {
            Debug.Log("Checkpoint");
            LevelManager.instance.Restart();
            Respawn();
        }
        else
        {
            SceneController.instance.RestartScene();
        }

        
    }

    public void SetInvencible(bool state)
    {
        if (state)
        {
            UiManager.instance.UpdateHealthBar(currentHealth);
            gameObject.layer = LayerMask.NameToLayer("Invencible");
        }            
        else
            gameObject.layer = defaultLayer;
    }

    
    


}
