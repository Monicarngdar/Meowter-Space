using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
   //Total health of player and using a sprite to display the health bar
   [Header("Health Variables")]
   public int health = 3; //Total health of player
   public Image[] hearts; //to display amount of hearts
   public Sprite currentHeart; //Full heart sprite
   public Sprite damageHeart; //Damage heart sprite

   //Animation Variable for the hurt animation
   private Animator animator;

   //Audio Variables
   [Header("Audio")]
   public AudioClip healthDamageSound;
   private AudioSource audioSource;
   
   void Awake()
   {
      animator = GetComponent<Animator>();//Gets the animation component
      audioSource = GetComponent<AudioSource>();//Audio source to be placed

      if (audioSource == null)
      {
         audioSource = gameObject.AddComponent<AudioSource>(); //Gets the audio source component
      }
      
      health = 3; //Player health sets initial to 3
   }
   
   //This method calls the collider when it is triggered that is attached to the object
   private void OnTriggerEnter(Collider other)
   {
      if (other.tag == "Asteroid")
      {
         TakeDamage(1); //Player takes one damage
      }
   }
  //Detects when the player is collided
   void OnCollisionEnter2D(Collision2D other)
   {
      if (other.gameObject.layer == LayerMask.NameToLayer("Enemy")) //Finds the layer called ''Enemy''
      {
         StartCoroutine(PlayerHurt()); //Player animation starts when the player gets hit by an obstacle
      }
   }
   
   //Applies damage to the player
 public void TakeDamage(int amount)
   {
      health -= amount; //Decrease amount of health
      if (health < 0) health = 0; //Ensure health does not go below zero

      UpdatedHearts(); //Updates the current hearts

      if (healthDamageSound != null && audioSource != null) 
      {
         audioSource.PlayOneShot(healthDamageSound); //Sound effect
      }

      //if health zero, it destroys the player
      if (health == 0) 
      {
         Destroy(gameObject);
      }
      
      else{
         StartCoroutine(PlayerHurt()); //Starts the hurt animation when player gets hit by an obstacle
      }
   }

  //Updates the heart icons
   private void UpdatedHearts()
   {
      for (int i = 0; i < hearts.Length; i++)
      {
         if (i < health)
            hearts[i].sprite = currentHeart; //sets it into the player heart remaining 
         else 
            hearts[i].sprite = damageHeart; //sets to damage heart
      }
   }

   //Coroutine to play the PlayerHurt animation  
   IEnumerator PlayerHurt()
   {
      if (animator != null)
      {
         animator.SetTrigger("Hurt"); //Triggers the Hurt animation 
      }
      
      Physics2D.IgnoreLayerCollision(6, 8); //Temporarily ignores the other collision when the player is hurt
      yield return new WaitForSeconds(2); //Time that the animation is set
      Physics2D.IgnoreLayerCollision(6, 8, false); //Re-enables it again when collided
   }
   
}
