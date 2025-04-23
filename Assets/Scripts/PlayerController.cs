using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    public int coinCollected = 0;
    public TextMeshProUGUI coinText;
    
    public GameObject smokeEffect;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity =  new Vector2(0, playerDirection.y * playerSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Asteroid"))
        {
            ObstacleHitSmokeEffect();
        }
        
        
        if(other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            coinCollected++;
            coinText.text = "Coins: " + coinCollected;
        }
    }

    void ObstacleHitSmokeEffect()
    {
        GameObject smoke = Instantiate(smokeEffect, transform.position, Quaternion.identity); 
        
        Destroy(smoke, 1f);
    }
}
