using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Make sure to include this if you're planning on using the SceneManager

public class Enemy : MonoBehaviour
{
    public float speed = 3f;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * speed * Time.deltaTime);    // Continuously move left
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // If this enemy collides with the player, restart the level
        if (other.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // You can restart the scene by calling this line
        }
    }
}
