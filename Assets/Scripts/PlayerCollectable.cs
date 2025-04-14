using UnityEngine;

public class PlayerCollectable : MonoBehaviour
{
    public GameObject collectable;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float TimeBetweenSpawn;
    private float SpawnTime;

    public float coinDistance; 
    public LayerMask obstacleMask;

    void Update()
    {
        if (Time.time > SpawnTime)
        {
            SpawnCoinEvenly();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    void SpawnCoinEvenly()
    {
        Vector3 spawnPos;
        int maxAttempts = 10;

        for (int i = 0; i < maxAttempts; i++)
        {
            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);
            spawnPos = transform.position + new Vector3(x, y, 0);

            if (!Physics2D.OverlapCircle(spawnPos, coinDistance, obstacleMask))
            {
                Instantiate(collectable, spawnPos, Quaternion.identity);
                return;
            }
        }
    }
}
    
 
