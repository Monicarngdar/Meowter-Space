using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
   public int health = 3;
   public Image[] hearts;
   
   public Sprite currentHeart;
   public Sprite damageHeart;

   void Update()
   {
      foreach (Image heart in hearts)
      {
         heart.sprite = damageHeart;
      }

      for (int i = 0; i < health; i++)
      {
         hearts[i].sprite = currentHeart;
      }
   }
   
   public void TakeDamage(int amount)
   {
      health -= amount;
      if (health < 0)
      {
         health = 0;
      }
   }
}
