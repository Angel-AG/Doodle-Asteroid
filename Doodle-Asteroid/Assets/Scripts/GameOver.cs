using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public Text finalScore;
    public TextMeshProUGUI punct;
    public GameObject GameOverUI;
    public GameObject background;
    private bool isGameOver = false;

    // Update is called once per frame
    void Update()
    {
        finalScore.text = punct.text;

        if ((GameObject.FindGameObjectWithTag("Player") == null && GameObject.FindGameObjectWithTag("Invulnerability") == null) && !isGameOver)
        {
            GameOverNow();
            background.GetComponent<AudioSource>().Stop();
            GameOverUI.GetComponent<AudioSource>().Play();
        }
    }

    void GameOverNow()
    {
        isGameOver = true;
        GameOverUI.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
