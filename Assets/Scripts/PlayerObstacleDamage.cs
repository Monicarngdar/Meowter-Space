using UnityEngine;

public class PlayerObstacleDamage : MonoBehaviour
{
    //This method calls te collider when it is triggered that is attached to the object
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit something!"); //A Debug to known when the obstacle is triggered
        if(other.CompareTag("Player")) //If the tag is called ''Player'' it gets collided
        {
            //It gets PlayerHealth Component from the collided object
            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();
            
            //If it is found, it takes damage to the player
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(1);
            }
            
            //Destroys the object once collided 
            Destroy(gameObject);
        }
    }

  
}
