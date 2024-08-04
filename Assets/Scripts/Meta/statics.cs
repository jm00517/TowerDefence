using UnityEngine;

public class Meta
{
    public enum TowerDamage
    {
        Level0 = 30,
        Level1 = 35,
        Level2 = 40,
        Level3 = 45,
        Level4 = 50,
        Level5 = 55,
        Level6 = 60,
        Level7 = 70,
        Level8 = 80,
        Level9 = 90,
        Level10 = 100,
        Level11 = 150,
        Level12 = 180,
        Level13 = 200,
    }


    
    public static int TowerAttackRadisFromLevel(int level)
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
            case 0: case 1: case 2: case 3:
                return 0.5f;
            case 4: case 5: case 6: case 7: case 8: case 9: case 10:
                return 0.3f;
            case 11: case 12: case 13:
                return 0.2f;
            
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

