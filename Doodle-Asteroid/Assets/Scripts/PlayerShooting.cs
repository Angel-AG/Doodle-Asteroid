using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public GameObject bullet;
    public Transform bulletSpawn;
    public float fireRate;

    private float nextFire;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1") && Time.time > nextFire && Time.timeScale != 0)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
