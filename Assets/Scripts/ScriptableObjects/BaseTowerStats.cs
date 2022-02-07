using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "towerStats", menuName = "objectStats/towerStats", order = 0)]
public class BaseTowerStats : ScriptableObject
{
    [SerializeField] GameObject projectile;
    public GameObject Projectile => projectile;
    
    [SerializeField] Sprite[] spritesGradesList;
    public Sprite[] SpritesGradesList => spritesGradesList;

    [SerializeField] float baseRange;
    public float BaseRange => baseRange;
    [SerializeField] float rangePerUpgrade;
    public float RangePerUpgrade => rangePerUpgrade;

    [SerializeField] float baseDamage;
    public float BaseDamage => baseDamage;
    [SerializeField] float damagePerUpgrade;
    public float DamagePerUpgrade => damagePerUpgrade;

    [SerializeField] float attackSpeed;
    public float AttackSpeed => attackSpeed;
    [SerializeField] float attackSpeedPerUpgrade;
    public float AttackSpeedPerUpgrade => attackSpeedPerUpgrade;

    [SerializeField] int baseTowerCost;
    public int BaseTowerCost => baseTowerCost;

    [SerializeField] int baseUpgradeCost;
    public int BaseUpgradeCost => baseUpgradeCost;
    [SerializeField] int addedCostPerUpgrade;
    public int AddedCostPerUpgrade => addedCostPerUpgrade;

    [SerializeField] LayerMask whatEnemiesCanAttack;
    public LayerMask WhatEnemiesCanAttack => whatEnemiesCanAttack;
}
