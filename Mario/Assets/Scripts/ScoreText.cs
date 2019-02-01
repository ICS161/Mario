using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    Player playerComponent;
    TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = this.GetComponent<TextMeshProUGUI>();
        //playerComponent = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerComponent = GameObject.Find("Player").GetComponent<Player>();
        //playerComponent.onCoinPickup.AddListener(OnCoinPickupListener);
        playerComponent.onCoinPickup += OnCoinPickupListener;
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = string.Format("Score: {0}", playerComponent.score);
    }

    void OnCoinPickupListener(int score)
    {
        //Debug.Log(score);
        scoreText.text = string.Format("Score: {0}", score);
    }
}
