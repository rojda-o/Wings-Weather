using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_sc : MonoBehaviour
{
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // Move the cloud from right to left across the screen
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // If the cloud moves off the left edge of the screen
        if (transform.position.x < -10.0f) 
        {
            float randomY = Random.Range(0f,4.4f); // Randomize the cloud's Y position to reappear at a new height
            transform.position = new Vector3(9, randomY, 0); // Reset the cloud's position to the right side of the screen
        }
    }
}
