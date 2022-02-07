using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseProjectile : MonoBehaviour
{
    int damage;
    float projectileSpeed;
    Transform target;
    public void InitProjectile(int _damage, float _projectileSpeed, Transform _target)
    {
        damage = _damage;
        projectileSpeed = _projectileSpeed;
        target = _target;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.Equals(target.gameObject))
        {
            HitTarget(other.GetComponent<BaseEnemy>());
        }    
    }

    void HitTarget(BaseEnemy enemy)
    {
        enemy.TakeDamage(damage);
        Destroy(this);
    }
}
