using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        Vector3 vel = new Vector3(0.0f, speed * Time.deltaTime, 0.0f);

        pos += transform.rotation * vel;

        transform.position = pos;
	}
}
