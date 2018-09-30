using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce;
    public float maxSpeed;
    public float sideForce;

	// Use this for initialization
	void Start () {
        
	}

    bool moveRight = false;
    bool moveLeft = false;
    void Update()
    {
        if (Input.GetKey("d"))
        {
            moveRight = true;
        }
        else if (Input.GetKey("a"))
        {
            moveLeft = true;
        }
        //using booleans to check for movement ensures that ALL input
        //is detected properly...and movement is uniform, because the
        //actual movement code is in FixedUpdate, which is consistant.
    }

	// Update is called once per frame
    // Use Fixed Update instead of Update for physics related stuff
	void FixedUpdate () {
        if (rb.velocity.z < maxSpeed)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
            Debug.Log(rb.velocity.z);
        }

        if (moveRight)
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            moveRight = false;
        }
        else if (moveLeft)
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            moveLeft = false;
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
