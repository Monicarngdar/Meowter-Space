using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem; //handling input
using TMPro; //Text mesh pro for text
public class ShootingEffect : MonoBehaviour
{
    //Laser Variables
    [Header("Laser Variable")]
    public Transform shootingPoint; //Position of when the laser is spawned
    public GameObject laserPrefab; //Prefab of the laser

    //Cooldown Variables
    [Header("Cooldown")]
    public int maxShoots = 3; //limited to 3 shots
    public float coolDown = 10f; //every 10 seconds the laser reloads
    private int shootsObstacle = 0;//tracks when the laser is shot
    private bool isCoolDown = false; //checks if the cooldown is active
    
    // text to display the timer
    [Header("Laser Text")]
    public TextMeshProUGUI laserTimer; //UI to show the text
    private float timer; //for the countdown

    //Audio Variables
    [Header("Audio")]
    public AudioClip shootSound; 
    private AudioSource audioSource;

    void Start()
    {
        //Get the audio source component to attached to the game object
        audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        //Uses space bar to shoot
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            //Ensures the player does not exceed the amount for shots
            if (shootsObstacle < maxShoots)
            {
                //The project file of laser
                Instantiate(laserPrefab,shootingPoint.position,transform.rotation);
                
                //Sound when player clicks on the space bar
                if (shootSound != null && audioSource != null)
                {
                    audioSource.PlayOneShot(shootSound);
                }
                
                //shot counter
                shootsObstacle++;
                
                //If max shot has been used the cooldown timer starts
                if (shootsObstacle == maxShoots)
                {
                    StartCoroutine(StartCoolDown());
                }
            }
          
        }
          
        //Shows the reloading text
        if (isCoolDown)
        {
            timer -= Time.deltaTime; //Decreases timer each time
            laserTimer.text = "Reloading: " + Mathf.Ceil(timer).ToString() + "s"; //Shows the remaining time
        }

        else
        {
            laserTimer.text = ""; //Hides it when not needed
        }
    }
    
    //Starts the timer after shooting the laser and waits for 10 seconds before shooting again
    IEnumerator StartCoolDown()
    {
        isCoolDown = true; //Starts the cooldown
        timer = coolDown; //The timer
        yield return new WaitForSeconds(coolDown); //Wait for seconds for the cooldown
        shootsObstacle = 0; //Resets the cooldown
        isCoolDown = false; //End of cooldown
    }
}
