using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawningBlock : MonoBehaviour
{
    public GameObject coinPrefab;

    void OnCollisionEnter2D(Collision2D other)
    {
        // If the Player collides with this block, spawn a coin 1-unit above
        if (other.collider.CompareTag("Player"))
        {
            Debug.Log("I'm going to spawn a coin");
            Vector2 oneUnitAboveMe = this.transform.position + Vector3.up;
            Instantiate(coinPrefab, oneUnitAboveMe, Quaternion.identity);
        }
    }
}
