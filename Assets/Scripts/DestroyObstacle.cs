using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "Border")
        {
            Destroy(this.gameObject);
        }
    }
   
}
