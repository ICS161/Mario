using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance = null;

    public int score = 0;

    public IntUnityEvent onScoreUpdate = new IntUnityEvent();

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void Start()
    {
        //Player.instance.onCoinPickup.AddListener(() => UpdateScore(++score));

    }

    void OnSceneLoaded(Scene loadedScene, LoadSceneMode sceneMode)
    {
        Player playerComponent = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerComponent.onCoinPickup.AddListener(() => UpdateScore(++score));

        Debug.Log(loadedScene.name);
        //UpdateScore(score);
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
