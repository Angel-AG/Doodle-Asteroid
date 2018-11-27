using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public float rotSpeed;

    private Transform target;

	// Use this for initialization
	void Start () {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }
	}
	
	// Update is called once per frame
	void Update () {
        
        if(target != null)
        {
            Vector3 dir = target.position - transform.position;
            dir.Normalize();

            float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

            Quaternion targetRot = Quaternion.Euler(0.0f, 0.0f, zAngle);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, rotSpeed * Time.deltaTime);
        }

    }
}
