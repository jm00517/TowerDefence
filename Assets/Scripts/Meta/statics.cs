using UnityEngine;

public class Meta
{
    public enum TowerDamage
    {
        Level0 = 30,
        Level1 = 50,
        Level2 = 50,
        Level3 = 70,
        Level4 = 80,
        Level5 = 100,
        Level6 = 120,
        Level7 = 140,
        Level8 = 160,
        Level9 = 180,
        Level10 = 200,
        Level11 = 200,
        Level12 = 300,
        Level13 = 500,
    }


    public static GameObject ProjectileFromLevel(int level)
    {
        switch (level)
        {
            case 0: 
                return (GameObject)Resources.Load("Prefabs/Projectiles/SlowProjectile_0");
            case 1: 
                return (GameObject)Resources.Load("Prefabs/Projectiles/StunProjectile_1");
            case 2: 
                return (GameObject)Resources.Load("Prefabs/Projectiles/Projectile_2");
            case 3:
                return (GameObject)Resources.Load("Prefabs/Projectiles/Projectile_3");
            case 4: 
                return (GameObject)Resources.Load("Prefabs/Projectiles/Projectile_4");
            case 5: 
                return (GameObject)Resources.Load("Prefabs/Projectiles/Projectile_5");
            case 6: 
                return (GameObject)Resources.Load("Prefabs/Projectiles/Projectile_6");
            case 7: case 8: 
                return (GameObject)Resources.Load("Prefabs/Projectiles/SplashProjectile_6");
            case 9: case 10:case 11: case 12: case 13:
                return (GameObject)Resources.Load("Prefabs/Projectiles/Projectile_6");
            default:
                return (GameObject)Resources.Load("Prefabs/Projectiles/Projectile_0");
        }
    }
    
    public static int TowerAttackRadiusFromLevel(int level)
    {
        switch (level)
        {
            case 0: case 1: case 2: case 3:
                return 3;
            case 4: case 5: case 6: case 7: case 8: case 9: case 10:
                return 4;
            case 11: case 12: case 13:
                return 5;
            
            default:
                return 3;
        }
    }
    public static float TowerAttackCooldownFromLevel(int level)
    {
        switch (level)
        {
            case 0:
                return 2f;
            case 1:
                return 0.5f;
            case 2: case 3:
                return 0.3f;
            case 4: case 5: case 6: case 7: case 8: case 9: case 10:
                return 0.1f;
            case 11: case 12: case 13:
                return 0.01f;
            
            default:
                return 0.5f;
        }
    }

    public static TowerDamage TowerDamageFromLevel(int level)
    {
        switch (level)
        {
            case 0:
                return TowerDamage.Level0;
            case 1:
                return TowerDamage.Level1;
            case 2:
                return TowerDamage.Level2;
            case 3:
                return TowerDamage.Level3;
            case 4:
                return TowerDamage.Level4;
            case 5:
                return TowerDamage.Level5;
            case 6:
                return TowerDamage.Level6;
            case 7:
                return TowerDamage.Level7;
            case 8:
                return TowerDamage.Level8;
            case 9:
                return TowerDamage.Level9;
            case 10:
                return TowerDamage.Level10;
            case 11:
                return TowerDamage.Level11;
            case 12:
                return TowerDamage.Level12;
            case 13:
                return TowerDamage.Level13;
            default:
                return TowerDamage.Level0;
        }
    }
}

class MobData
{
    public static MobSpawnRule GetMobSpawnRule(int stage)
    {
        switch (stage)
        {
            case 0:
                return new MobSpawnRule(MobType.Shark, 10, 50, 3, 1);
            case 1:
                return new MobSpawnRule(MobType.Shark, 20, 100, 3, 0.5f);
            case 2:
                return new MobSpawnRule(MobType.Shark, 40, 200, 3, 0.25f);
            case 3:
                return new MobSpawnRule(MobType.Shark, 20, 400, 3, 0.5f);
            case 4:
                return new MobSpawnRule(MobType.Shark, 40, 800, 3, 0.25f);
            case 5:
                return new MobSpawnRule(MobType.Shark, 1, 100000, 0.5f, 0.2f);
            case 6:
                return new MobSpawnRule(MobType.Shark, 100, 3200, 3, 0.1f);
            case 7:
                return new MobSpawnRule(MobType.Shark, 100, 6400, 3, 0.1f);
            case 8:
                return new MobSpawnRule(MobType.Shark, 200, 12800, 3, 0.05f);
            case 9:
                return new MobSpawnRule(MobType.Shark, 200, 25600, 3, 0.05f);
            case 10:
                return new MobSpawnRule(MobType.Shark, 200, 5120000, 1, 0.05f);
            case 11:
                return new MobSpawnRule(MobType.Shark, 200, 102400, 3, 0.05f);
            case 12:
                return new MobSpawnRule(MobType.Shark, 250, 204800, 3, 0.25f);
            case 13:
                return new MobSpawnRule(MobType.Shark, 200, 300000, 3, 0.05f);
            case 14:
                return new MobSpawnRule(MobType.Shark, 200, 400000, 3, 0.05f);
            case 15:
                return new MobSpawnRule(MobType.Shark, 200, 500000, 3, 0.05f);
            case 16:
                return new MobSpawnRule(MobType.Shark, 200, 600000, 3, 0.05f);
            case 17:
                return new MobSpawnRule(MobType.Shark, 200, 700000, 3, 0.05f);
            case 18:
                return new MobSpawnRule(MobType.Shark, 200, 800000, 3, 0.05f);
            case 19:
                return new MobSpawnRule(MobType.Shark, 200, 900000, 3, 0.05f);
            case 20:
                return new MobSpawnRule(MobType.Shark, 200, 1000000, 3, 0.05f);
            default:
                return new MobSpawnRule(MobType.Shark, 200, 50, 3, 0.05f);
        }
    }
}
