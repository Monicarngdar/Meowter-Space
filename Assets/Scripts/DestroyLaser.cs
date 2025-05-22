using UnityEngine;

public class DestroyLaser : MonoBehaviour
{
    //When the laser hits the border outside the screen it gets destroyed
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "Laser")
        {
            Destroy(this.gameObject);
        }
    }
}
