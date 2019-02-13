using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public int score = 0;

    public IntUnityEvent onScoreUpdate = new IntUnityEvent();

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Player.instance.onCoinPickup.AddListener(() => UpdateScore(++score));
    }

    void UpdateScore(int newScore)
    {
        score = newScore;
        onScoreUpdate.Invoke(newScore);
    }

    void DecrementScore()
    {
        UpdateScore(--score);
    }
}
