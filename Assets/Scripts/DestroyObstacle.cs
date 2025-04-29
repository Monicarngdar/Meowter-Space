using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    //When the obstacle hits the border on the side of the screen it gets destroyed
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "Border")
        {
            Destroy(this.gameObject);
        }
    }
   
}
