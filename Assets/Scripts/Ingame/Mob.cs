using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{

    public float speed = 5f;

    private Vector3 target;
    private int waypointIndex = 0;

    public MobHealth  Health { get; set; }
    
    List<Vector3> wayPoints;

    void Start()
    {
    }

    void Update()
    {
        Vector3 dir = target - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target) <= 0.05f)
        {
            GetNextWaypoint();
        }
    }

    public void Initialize(int mobId, string resourcePath, List<Vector3> wayPoints)
    {
        transform.Translate(wayPoints[0]);
        SetSpriteRenderer(resourcePath);
        this.wayPoints = wayPoints;
        target = wayPoints[1];
    }

    void SetSpriteRenderer(string resourcePath)
    {
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>() as SpriteRenderer;
        spriteRenderer.sprite = Resources.Load(resourcePath, typeof(Sprite)) as Sprite;
        spriteRenderer.sortingOrder = 1;
    }

    void GetNextWaypoint()
    {
        if (waypointIndex >= wayPoints.Count - 1)
        {
            Destroy(gameObject);
            return;
        }

        waypointIndex++;
        
        target = wayPoints[waypointIndex];
    }
}

public class MobHealth: MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        //Destroy job
        Destroy(gameObject);
    }
}
