using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float speed = 5; // Movement speed of the bird
    public int lives = 3; // Number of lives the bird starts with
    public TMP_Text livesText; // Text object to display the current number of lives
    SpawnManager_sc spawnManager_sc; // Reference to the SpawnManager script

    void Update()
    {
        // Get horizontal and vertical input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * speed * Time.deltaTime);

        // Restrict the bird's movement within certain boundaries on the screen
        transform.position = new Vector3(Math.Clamp(transform.position.x, -8.25f, -4.5f), Math.Clamp(transform.position.y, 0f,4.4f), 0);

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SunnyCloud"))
        {
            lives++; //If the bird collides with a SunnyCloud increase the lives
            Destroy(other.gameObject); //remove the cloud
            livesText.text = "LIVES: "+lives; // Update the lives display
        }
        else if (other.CompareTag("StormyCloud"))
        {
            lives--; ////If the bird collides with a StormyCloud decrease the lives
            Destroy(other.gameObject);  //remove the cloud
            livesText.text = "LIVES: "+lives; 
        }

        // If the bird runs out of lives
        if(lives < 1)
        {
            if(spawnManager_sc != null) // Notify the SpawnManager to stop spawning clouds
            {
                spawnManager_sc.OnPlayerDeath();
            }
            Destroy(this.gameObject); // Destroy the bird object

            // Restart the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
    }
    
}
