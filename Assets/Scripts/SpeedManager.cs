using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    
    public static SpeedManager Instance;
    
    public float gameSpeed = 5f;
    public float increaseSpeed = 0.2f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        gameSpeed += increaseSpeed * Time.deltaTime;
    }
    
}
