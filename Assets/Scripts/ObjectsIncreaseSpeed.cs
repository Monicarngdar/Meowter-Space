using UnityEngine;

public class ObjectsIncreaseSpeed : MonoBehaviour
{
    
    void Update()
    {
        transform.position += Vector3.left * SpeedManager.Instance.gameSpeed * Time.deltaTime;
    }
}
