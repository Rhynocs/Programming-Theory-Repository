using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static UnityEvent onDestroy;
    public static UnityEvent<int> trigger;
    public static bool isGameOver = false;    

    [SerializeField] private GameObject bigCircle;
    [SerializeField] private GameObject smallCircle;

    private void Awake()
    {
        onDestroy = new UnityEvent();
        trigger = new UnityEvent<int>();

        onDestroy.AddListener(SpawnRandomCircle);
        trigger.AddListener(AddScore);
    }

    private void Start()
    {
        SpawnRandomCircle();
    }

    public void SpawnRandomCircle()
    {
        float value = Random.value;
        GameObject circle = (value > 0.2) ? bigCircle : smallCircle;

        Instantiate(circle, null);
    }

    private void AddScore(int score)
    {
        
    }
}
