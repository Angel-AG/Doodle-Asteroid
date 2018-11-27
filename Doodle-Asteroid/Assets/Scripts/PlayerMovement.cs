using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float rotationSpeed;

    public float playerBoundary;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float rotateHorizontal = -Input.GetAxis("Horizontal") * rotationSpeed;
        float moveVertical = speed;
        
        if(Input.GetAxis("Vertical") > 0.0f){
            moveVertical += Input.GetAxis("Vertical") * 2.0f;
        }
        else if (Input.GetAxis("Vertical") < 0.0f)
        {
            moveVertical += Input.GetAxis("Vertical") * 1.5f;
        }

        rotateHorizontal *= Time.deltaTime;
        moveVertical *= Time.deltaTime;

        transform.Translate(0.0f, moveVertical, 0.0f);
        transform.Rotate(0.0f, 0.0f, rotateHorizontal);

        Vector3 pos = transform.position;
        float ScreenRatio = (float) Screen.width / (float)Screen.height;
        float width = Camera.main.orthographicSize * ScreenRatio;

        if (pos.y + playerBoundary > Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
        else if (pos.y - playerBoundary < -Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
        else if (pos.x + playerBoundary > width)
        {
            Destroy(gameObject);
        }
        else if (pos.x - playerBoundary < -width)
        {
            Destroy(gameObject);
        }


        transform.position = pos;
    }
}
