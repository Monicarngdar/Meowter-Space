using UnityEngine;

public class LaserShoots : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    public GameObject particleEffect;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * speed;
    }




    private void OnTriggerEnter2D(Collider2D other)
    {
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
