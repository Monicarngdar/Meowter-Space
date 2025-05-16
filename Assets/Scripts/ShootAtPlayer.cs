using UnityEngine;

public class ShootAtPlayer : MonoBehaviour
{
   public float speed = -4; //The speed that the objects moves
   private Rigidbody2D rb; //Reference to the Rigidbody2D
   
   private void Start()
   {
      //Get the Rigidbody2D attached to the game object
      rb = GetComponent<Rigidbody2D>();
      //Sets the linear velocity to move at a specific speed
      rb.linearVelocityX = speed;
   }
   
   //Reference to the Speed Manager Script
   void Update()
   {
      transform.position += Vector3.left * SpeedManager.Instance.gameSpeed * Time.deltaTime;
   }
   
}
