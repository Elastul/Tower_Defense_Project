using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTower : MonoBehaviour
{
    BaseTowerStats towerStats;
    float attackRange;
    Transform attackTarget;
    void Attack(Transform target)
    {
        if(attackTarget != null)
        {
            CreateProjectile(towerStats.Projectile, attackTarget);
        }
    }
    Transform SearchForTarget()
    {
        return Physics2D.OverlapCircle(transform.position, attackRange, towerStats.WhatEnemiesCanAttack).transform;
    }
    void CreateProjectile(GameObject projectile, Transform target)
    {
        GameObject projectileTemp = Instantiate(projectile, transform.position, Quaternion.Euler(Vector3.zero));
        projectileTemp.GetComponent<BaseProjectile>();
    }
    public void TowerUpgrade()
    {
        throw new System.NotImplementedException();
    }
}
