using System.Collections;
using System.Collections.Generic;
using Ingame;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    private bool isSpawningTime;
    private int towerId;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTower(Vector3 cellPos, int level)
    {
        cellPos.x += 0.5f;
        cellPos.y += 0.5f;
        
        GameObject towerPrefab;
        towerPrefab = (GameObject)Resources.Load("Prefabs/Towers/Tower" + level.ToString());

        GameObject tower = Instantiate(towerPrefab, cellPos, Quaternion.identity);
        if (level == 0 )
        {
            tower.GetComponent<SlowTower>().SetData(level, false);
        }
        else if (level == 1)
        {
            tower.GetComponent<StunTower>().SetData(level, false);
        }
        else if (level ==3 || level == 4)
        {
            tower.GetComponent<SplashTower>().SetData(level, false);
        } else if (level == 7 || level == 8)
        {
            tower.GetComponent<SplashTower>().SetData(level, false);
        } else
        {
            tower.GetComponent<Tower>().SetData(level, false);    
        }
    }
}
