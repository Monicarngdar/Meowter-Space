using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
   //Total health of player and using a sprite to display the health bar
   [Header("Health Variables")]
   public int health = 3;
   public Image[] hearts;
   public Sprite currentHeart;
   public Sprite damageHeart;

   //Animatio Variable
   private Animator animator;

   //Audio Variable
   [Header("Audio")]
   public AudioClip healthDamageSound;
   private AudioSource audioSource;
   
   void Awake()
   {
      animator = GetComponent<Animator>();
      audioSource = GetComponent<AudioSource>();

      if (audioSource == null)
      {
         audioSource = gameObject.AddComponent<AudioSource>();
      }
      
      health = 3;
   }
   
   private void OnTriggerEnter(Collider other)
   {
      if (other.tag == "Asteroid")
      {
         TakeDamage(1);
      }
   }

   void OnCollisionEnter2D(Collision2D other)
   {
      if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
      {
         StartCoroutine(PlayerHurt());
      }
   }
   
 public void TakeDamage(int amount)
   {
      health -= amount;
      if (health < 0) health = 0;

      UpadatedHearts();

      if (healthDamageSound != null && audioSource != null)
      {
         audioSource.PlayOneShot(healthDamageSound);
      }

      
      if (health == 0)
      {
         Destroy(gameObject);
      }
      
      else{
         StartCoroutine(PlayerHurt());
      }
   }

   private void UpadatedHearts()
   {
      for (int i = 0; i < hearts.Length; i++)
      {
         if (i < health)
            hearts[i].sprite = currentHeart;
         else 
            hearts[i].sprite = damageHeart;
      }
   }

  
   IEnumerator PlayerHurt()
   {
      if (animator != null)
      {
         animator.SetTrigger("Hurt");
      }
      
      Physics2D.IgnoreLayerCollision(6, 8);
      yield return new WaitForSeconds(2);
      Physics2D.IgnoreLayerCollision(6, 8, false);
   }
   
}
