using UnityEngine;

public class PlayerCollectable : MonoBehaviour
{
    //to place the object
    public GameObject collectable;
    //coins spawn in different direction as the gameplay progresses
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    //The coins spawns depending on the time
    public float TimeBetweenSpawn;
    private float SpawnTime;
    

    void Update()
    {
        if(GameManager.Instance.isGameOver) return; //Freezes the collectable in the background when player is game over
        //Checks if the time is spawned
        if (Time.time > SpawnTime)
        {
            Spawn();//Calls out the Spawn method 
            SpawnTime = Time.time + TimeBetweenSpawn; //Sets the next spawn time
            
        }
    }

    void Spawn()
    {
        //Randomly spawns the coins within the specific range mentioned
        float X = Random.Range(minX, maxX);
        float Y = Mathf.Floor(Random.Range(minY, maxY));
        
        Instantiate(collectable, transform.position + new Vector3(X,Y, 0f), transform.rotation);
    }
    
}
    
 
