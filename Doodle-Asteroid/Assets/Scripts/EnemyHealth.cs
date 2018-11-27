using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealth : MonoBehaviour {

    public int health;
    public bool spawnSomething;
    public GameObject objectToSpawn;
    public Transform whereToSpawn;
    private GameObject punct;
    private ScoreUI points;

	// Use this for initialization
	void Start () {
        if (GameObject.FindGameObjectWithTag("Score") != null)
        {
            punct = GameObject.FindGameObjectWithTag("Score");
        }
    }
	
	// Update is called once per frame
	void Update () {
        points = punct.GetComponent<ScoreUI>();
        if (health <= 0)
        {
            if (spawnSomething)
            {
                Quaternion rot = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                rot.z = Random.Range(-5.0f, 5.0f);
                Instantiate(objectToSpawn, whereToSpawn.position, rot);
                rot.z = Random.Range(-5.0f, 5.0f);
                Instantiate(objectToSpawn, whereToSpawn.position, rot);
            }
            points.score += 100;
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Beam")
        {
            Destroy(other.gameObject);
            health--;
        }
        else if (other.gameObject.tag != "Background" && other.gameObject.tag != "EnemyHazards")
        {
            health--;
        }
    }
}
