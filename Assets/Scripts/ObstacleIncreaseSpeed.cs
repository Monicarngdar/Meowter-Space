using UnityEngine;

public class ObstacleIncreaseSpeed : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.left * SpeedManager.Instance.gameSpeed * Time.deltaTime;

        if (transform.position.x < -20f)
        {
            Destroy(gameObject);
        }
    }
}
