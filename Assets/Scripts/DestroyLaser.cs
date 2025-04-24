using UnityEngine;

public class DestroyLaser : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "Laser")
        {
            Destroy(this.gameObject);
        }
    }
}
