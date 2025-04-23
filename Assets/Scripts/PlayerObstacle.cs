using UnityEngine;

public class PlayerObstacle : MonoBehaviour
{
    //obstacles spawn in different direction as the gameplay progresses
   public GameObject obstacle;
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
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float X = Random.Range(minX, maxX);
        float Y = Random.Range(minY, maxY);
        
        Instantiate(obstacle, transform.position + new Vector3(X,Y, 0), transform.rotation);
    }
}
