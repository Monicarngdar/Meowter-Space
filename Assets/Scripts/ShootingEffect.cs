using UnityEngine;
using UnityEngine.InputSystem;
public class ShootingEffect : MonoBehaviour
{
    public Transform shootingPoint; 
    public GameObject laserPrefab;
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(laserPrefab,shootingPoint.position,transform.rotation);
        }
    }
}
