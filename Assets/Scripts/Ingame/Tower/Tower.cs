using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ingame;

public class Tower : MonoBehaviour
{
    protected int id;
    protected int _level;
    protected int _damage;
    protected float _attackCooldown; // seconds
    protected float _cooldownTimer = 0f;
    
    protected int _attackRadius;
    protected bool _bDisplayMode = false;
    
    // prefabs
    public GameObject imgProjectile;
    
    // Start is called before the first frame update

    protected void Awake()
    {

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_bDisplayMode) return;

        var Mobs = FindObjectsByType<Mob>(FindObjectsSortMode.InstanceID);
        foreach (var mob in Mobs)
        {
            // 사거리 체크
            if (Vector3.Distance(mob.transform.position, transform.position) <= _attackRadius)
            {
                _cooldownTimer += Time.deltaTime;
                if (_cooldownTimer >= _attackCooldown)
                {
                    _cooldownTimer = 0f;
                    SpawnProjectile(mob.GetID(), _damage);

                    break;
                }
            }
        }
    }

    public void SetData(int level, bool bDisplayMode)
    {
        _level = level;
        // int to enum
        _damage = (int)Meta.TowerDamageFromLevel(level);
        _attackCooldown = Meta.TowerAttackCooldownFromLevel(level);
        _attackRadius = Meta.TowerAttackRadiusFromLevel(level);
        _bDisplayMode = bDisplayMode;

        imgProjectile = Meta.ProjectileFromLevel(level);
    }

    protected void SpawnProjectile(int targetMobId, int damage)
    {
        GameObject projectile = Instantiate(imgProjectile, gameObject.transform.position, Quaternion.identity);
        Projectile towerProjectile = projectile.GetComponent<Projectile>();
        towerProjectile.Initialize(id, damage, targetMobId);
    }
}