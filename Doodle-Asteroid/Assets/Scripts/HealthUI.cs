using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthUI : MonoBehaviour {

    private GameObject player;
    private PlayerHealth life;
    public TextMeshProUGUI healthText;

	// Use this for initialization
	void Start () {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (player != null)
        {
            life = player.GetComponent<PlayerHealth>();
            healthText.text = "Health: " + life.health.ToString();
        }
        else
        {
            healthText.text = "Health: 0";
        }
	}
}
