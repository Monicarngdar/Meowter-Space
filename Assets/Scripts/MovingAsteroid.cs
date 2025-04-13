using UnityEngine;

public class MovingAsteroid : MonoBehaviour
{
  public GameObject asteroid;
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
      SpawnAsteroids();
      SpawnTime = Time.time + TimeBetweenSpawn;
    }
  }

  void SpawnAsteroids()
  {
    
  }

  
  
}
