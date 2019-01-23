using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        // Match camera's position to the player's x and y positions, but maintain a zPosition of -10
        Vector3 playerPosition = player.transform.position;
        this.transform.position = new Vector3(playerPosition.x, playerPosition.y, -10);
    }
}
