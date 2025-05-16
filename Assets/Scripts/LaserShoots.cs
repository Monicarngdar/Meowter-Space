using UnityEngine;

public class LaserShoots : MonoBehaviour
{
    //Speed of the laser when the player clicks the space key
    [Header("Laser Speed")]
    public float speed;
    private Rigidbody2D rb;

    //Particle Effect 
    [Header("Particle")]
    public GameObject particleEffect;
    
    //Audio Variables 
    [Header("Audio")]
    public AudioClip hitFireSound;
    private AudioSource audioSource;
    void Start()
    {
        //Gets the Rigidbody2D attached to the object
        rb = GetComponent<Rigidbody2D>();
        //Sets the linearVelocity of the Rigidbody2D in the direction and speed
        rb.linearVelocity = transform.right * speed;
    }

    //This method calls te collider when it is triggered that is attached to the object
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Asteroid")) //If the asteroid has a tag 
        {
            if (hitFireSound != null)
                AudioSource.PlayClipAtPoint(hitFireSound, transform.position); //Audio played when the laser hits the asteroid

            if (particleEffect != null)
                Instantiate(particleEffect, transform.position, Quaternion.identity); //Particle effect is shown
            
            //Destroys the laser and asteroid game objects
            Destroy(other.gameObject); 
            Destroy(gameObject);
        }
    }
  
}
