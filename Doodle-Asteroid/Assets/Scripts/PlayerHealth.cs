using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int health;
    public float InvulnerabilityRate;

    private float nextInvulnerability;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextInvulnerability && Time.timeScale != 0)
        {
            gameObject.tag = "Player";
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyHazards" && gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            health--;
            gameObject.tag = "Invulnerability";
            nextInvulnerability = Time.time + InvulnerabilityRate;
        }
    }
}
