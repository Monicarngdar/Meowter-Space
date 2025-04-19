using UnityEngine;

public class MovingSpeed : MonoBehaviour
{
    void Update()
    {
        float speed = SpeedManager.Instance.gameSpeed;
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
