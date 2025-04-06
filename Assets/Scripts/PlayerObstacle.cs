using UnityEngine;

public class PlayerObstacle : MonoBehaviour
{
   public GameObject obstacle;
   public float maxX;
   public float maxY;
   public float minX;
   public float minY;
   public float timeSpawn;
   private float spawnRate;
   
   
    void Update()
    {
        if (Time.time > timeSpawn)
        {
            Spawn();
            timeSpawn = Time.time + spawnRate;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
