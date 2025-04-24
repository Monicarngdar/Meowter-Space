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
    

    void Update()
    {
        if (Time.time > SpawnTime)
        {
            SpawnTime = Time.time + TimeBetweenSpawn;
            
            Spawn();
        }
    }

    void Spawn()
    {
        float X = Random.Range(minX, maxX);
        float Y = Random.Range(minY, maxY);
        
        Instantiate(collectable, transform.position + new Vector3(X,Y, 0), transform.rotation);
    }
    
}
    
 
