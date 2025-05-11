using UnityEngine;

public class ObjectsIncreaseSpeed : MonoBehaviour
{
    //Reference to the Speed Manager Script
    void Update()
    {
        transform.position += Vector3.left * SpeedManager.Instance.gameSpeed * Time.deltaTime;
    }
}
