using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    //public PlayerMovement movement;


	void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //first method sets PlayerMovement as a variable
            //does work, but GetComponent is shorter.
            //Using the variable does however make it modifyiable in Unity
            //as a property, which is easier to change.
            //movement.enabled = false;
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            Debug.Log("Hit something");
        }
       
    }
}
