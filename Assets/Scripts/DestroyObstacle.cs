using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(0);
            }
            
        }
    }
   
}
