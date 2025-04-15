using UnityEngine;

public class ShootAtPlayer : MonoBehaviour
{
   public float speed = -4;
   private Rigidbody2D rb;
   
   private void Start()
   {
      rb = GetComponent<Rigidbody2D>();
      rb.linearVelocityX = speed;
   }
   
}
