using UnityEngine;

public class LaserShoots : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Asteroid"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
  
}
