using System;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
   public int health = 3;
   public Image[] hearts;
   
   public Sprite currentHeart;
   public Sprite damageHeart;

 public void TakeDamage(int amount)
   {
      health -= amount;
      if (health < 0) health = 0;

      UpadatedHearts();

      if (health == 0)
      {
         Destroy(gameObject);
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
}
