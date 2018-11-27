using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIntoZone : MonoBehaviour {

    private float speed;

	// Use this for initialization
	void Start () {
        Vector3 pos = transform.position;
        if (pos.x > 0.0f)
        {
            speed = Random.Range(-1.0f, -5.0f);
        }
        else {
            speed = Random.Range(1.0f, 5.0f);
        }
	}
    // Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        Vector3 vel = new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);

        pos += transform.rotation * vel;

        transform.position = pos;
    }
}