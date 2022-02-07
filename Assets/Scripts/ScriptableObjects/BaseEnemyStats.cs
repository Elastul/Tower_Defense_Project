using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "enemyStats", menuName = "objectStats/enemyStats", order = 1)]
public class BaseEnemyStats : ScriptableObject
{
    [SerializeField] int maxHealth;
    public int MaxHealth => maxHealth;
    [SerializeField] float moveSpeed;
    public float MoveSpeed => moveSpeed;
    [SerializeField] int damage;
    public int Damage => damage;

    [SerializeField] int enemyCost;
    public int EnemyCost => enemyCost;
}
