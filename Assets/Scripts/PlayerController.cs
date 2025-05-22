using UnityEngine;
using TMPro; //Text to show the UI element

public class PlayerController : MonoBehaviour
{
    //Player Movement Variables
    public float playerSpeed; //Speed to move the player
    private Rigidbody2D rb; //Reference the Rigidbody2D component attached
    private Vector2 playerDirection; //Stores the direction when the player is moving

    //Text for coin collectable
    [Header("Coin Collectable")]
    public int coinCollected = 0;//To display the number of coins that are collection
    public TextMeshProUGUI coinText; //To show the text
    
    //Audio Variables
    [Header("Audio")]
    public AudioClip coinSound;
    private AudioSource audioSource;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Gets the Rigidbody2D attached to the player
        audioSource = GetComponent<AudioSource>(); //Audio to be placed
    }

    //Player moves using up and down keys
    void Update()
    {
        //Uses up and down or w and s keys to move
        float directionY = Input.GetAxisRaw("Vertical");
        //consistent speed
        playerDirection = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        //Apply the movement to the Rigidbody2D by its velocity and only allows the player to move vertical
        rb.linearVelocity =  new Vector2(0, playerDirection.y * playerSpeed);
    }
     
    //This method calls te collider when it is triggered that is attached to the object
    void OnTriggerEnter2D(Collider2D other)
    {
        
        //If game object has a tag of Coin, it gets trigger and collected
        if(other.gameObject.CompareTag("Coin"))
        {
            //Destroys the coin object
            other.gameObject.SetActive(false);
            coinCollected++;
            coinText.text = "Coins: " + coinCollected;
            
            //Coin Sound
            if(coinSound != null)
                audioSource.PlayOneShot(coinSound);
        }
    }
    
}
