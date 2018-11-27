using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour {

    public int score = 0;
    private GameObject enemy;
    private EnemyHealth life;
    public TextMeshProUGUI scoreText;
    private GameObject player;

    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            //score += (int) Time.time;
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
