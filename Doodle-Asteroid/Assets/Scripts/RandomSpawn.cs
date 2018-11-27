using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

    public GameObject objectToSpawn;
    public Transform objectSpawn;
    public float objectRate;
    public float minMaxY, minMaxX;

    private float nextObject;
    private bool leftRight = true;
    //private bool upDown = true;

	// Update is called once per frame
	void Update () {
        if (Time.time > nextObject)
        {
            float x;
            if (leftRight)
            {

                x = ((Camera.main.orthographicSize * 2.0f / Screen.height * Screen.width) * 0.5f) + minMaxX;
            }
            else
            {
                x = ((Camera.main.orthographicSize * 2.0f / Screen.height * Screen.width) * -0.5f) - minMaxX;
            }
            float y = Random.Range(-minMaxY, minMaxY);
            Vector3 spawn = transform.position;
            spawn.x = x;
            spawn.y = y;

            nextObject = Time.time + objectRate;
            Instantiate(objectToSpawn, spawn, objectSpawn.rotation);
            leftRight = !(leftRight);
        }
    }
}
