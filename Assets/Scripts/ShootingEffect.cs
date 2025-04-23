using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class ShootingEffect : MonoBehaviour
{
    public Transform shootingPoint; 
    public GameObject laserPrefab;

    public int maxShoots = 3;
    public float coolDown = 10f;

    private int shootsObstacle = 0;
    private bool isCoolDown = false;
    
    public TextMeshProUGUI laserTimer;
    private float timer;
    void Update()
    {
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
            timer -= Time.deltaTime;
            laserTimer.text = "Timer: " + Mathf.Ceil(timer).ToString() + "s";
        }

        else
        {
            laserTimer.text = "";
        }
    }

    IEnumerator StartCoolDown()
    {
        isCoolDown = true;
        yield return new WaitForSeconds(coolDown);
        shootsObstacle = 0;
        isCoolDown = false;
    }
}
