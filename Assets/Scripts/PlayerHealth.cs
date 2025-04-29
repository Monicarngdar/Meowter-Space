using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
   public int health = 3;
   public Image[] hearts;
   
   public Sprite currentHeart;
   public Sprite damageHeart;

   private Animator animator;

   void Awake()
   {
      animator = GetComponent<Animator>();
      health = 3;
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
