using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class ShootingEffect : MonoBehaviour
{
    //Allows the player to shoot to kill the Asteroids
    [Header("Laser Variable")]
    public Transform shootingPoint; 
    public GameObject laserPrefab;

    // Is limited to only 3 every 10 seconds
    [Header("Colldown")]
    public int maxShoots = 3;
    public float coolDown = 10f;
    private int shootsObstacle = 0;
    private bool isCoolDown = false;
    
    // text to display the timer
    [Header("Laser Text")]
    public TextMeshProUGUI laserTimer;
    private float timer;

    //Audio Variables
    [Header("Audio")]
    public AudioClip shootSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        //Uses space bar to shoot
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (shootsObstacle < maxShoots)
            {
                //The project file of laser
                Instantiate(laserPrefab,shootingPoint.position,transform.rotation);
                
                //Sound when player clicks on the space bar
                if (shootSound != null && audioSource != null)
                {
                    audioSource.PlayOneShot(shootSound);
                }
                
                shootsObstacle++;

                if (shootsObstacle == maxShoots)
                {
                    StartCoroutine(StartCoolDown());
                }
            }
          
        }
          
        //Shows the reloading text
        if (isCoolDown)
        {
            timer -= Time.deltaTime;
            laserTimer.text = "Reloading: " + Mathf.Ceil(timer).ToString() + "s";
        }

        else
        {
            laserTimer.text = "";
        }
    }
    
    //Starts the timer after shooting the laser and waits for 10 seconds before shooting again
    IEnumerator StartCoolDown()
    {
        isCoolDown = true;
        timer = coolDown;
        yield return new WaitForSeconds(coolDown);
        shootsObstacle = 0;
        isCoolDown = false;
    }
}
