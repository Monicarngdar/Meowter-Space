using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //Player Movement Variables
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    //Text for coin collectable
    [Header("Coin Collectable")]
    public int coinCollected = 0;
    public TextMeshProUGUI coinText;
    
    //Audio Variables
    [Header("Audio")]
    public AudioClip coinSound;
    private AudioSource audioSource;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    //Player moves using up and down keys
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
          
        }
        
        
        if(other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            coinCollected++;
            coinText.text = "Coins: " + coinCollected;
            
            //Coin Sound
            if(coinSound != null)
                audioSource.PlayOneShot(coinSound);
        }
    }

   
}
