using UnityEngine;

public class LaserShoots : MonoBehaviour
{
    //Speed of the laser 
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
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * speed;
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (hitFireSound != null)
            AudioSource.PlayClipAtPoint(hitFireSound, transform.position);
        
        
        
        if (other.CompareTag("Asteroid"))
        {

            if (particleEffect != null)
            {
                Instantiate(particleEffect, transform.position, Quaternion.identity);
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
  
}
