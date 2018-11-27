using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour {

    public Text finalScore;
    public TextMeshProUGUI punct;
    public GameObject time;
    public GameObject WinUI;
    public GameObject background;

    // Update is called once per frame
    void Update()
    {
        finalScore.text = punct.text;

        if (time.GetComponent<TimeSurvive>().survive <= 0)
        {
            Win();
            background.GetComponent<AudioSource>().Stop();
        }
    }

    void Win()
    {
        Time.timeScale = 0f;
        WinUI.SetActive(true);
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
