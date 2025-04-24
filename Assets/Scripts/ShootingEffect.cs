using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class ShootingEffect : MonoBehaviour
{
    //allows the player to shoot to kill the Asteroids
    public Transform shootingPoint; 
    public GameObject laserPrefab;

    // is limited to only 3 every 10 seconds
    public int maxShoots = 3;
    public float coolDown = 10f;

    private int shootsObstacle = 0;
    private bool isCoolDown = false;
    
    
    public TextMeshProUGUI laserTimer;
    private float timer;
    void Update()
    {
        //uses space bar to shoot
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (shootsObstacle < maxShoots)
            {
                Instantiate(laserPrefab,shootingPoint.position,transform.rotation);
                shootsObstacle++;

                if (shootsObstacle == maxShoots)
                {
                    StartCoroutine(StartCoolDown());
                }
            }
          
        }

        if (isCoolDown)
        {
            timer = Time.deltaTime;
            laserTimer.text = "Wait for: " + Mathf.Ceil(timer).ToString() + "s";
        }

        else
        {
            laserTimer.text = "";
        }
    }

    IEnumerator StartCoolDown()
    {
        isCoolDown = true;
        timer = coolDown;
        yield return new WaitForSeconds(coolDown);
        shootsObstacle = 0;
        isCoolDown = false;
    }
}
