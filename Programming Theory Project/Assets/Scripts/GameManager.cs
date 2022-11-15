using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static UnityEvent onDestroy;
    public static UnityEvent<int> trigger;
    public static bool isGameOver = false;    

    [SerializeField] private GameObject bigCircle;
    [SerializeField] private GameObject smallCircle;
    [SerializeField] private GameObject trapCircle;
    [SerializeField] private TextMeshProUGUI text;

    private int score;

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
        GameObject circle = (value > 0.4) ? bigCircle : (value > 0.2) ? smallCircle : trapCircle;

        Instantiate(circle, null);
    }

    private void AddScore(int score)
    {
        this.score += score;
        text.text = this.score.ToString();
    }
}
