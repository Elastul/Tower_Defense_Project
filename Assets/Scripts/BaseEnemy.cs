using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    
    int currentHealth;
    int coinPrice;
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
            return;
            //StartDeathAnimation();
    }

    void Death()
    {
        DropCoins(coinPrice);
        Destroy(this);
    }

    void DropCoins(int amount)
    {
        throw new System.NotImplementedException();
    }
}
