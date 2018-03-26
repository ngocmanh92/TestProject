using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {


    Rigidbody2D myRigidBody;
	Rigidbody2D myRigidBody2;
    float speed;
    float speedX = 2.6f;
	float speedX2 = 12f;
	public GameObject oj1;
	public GameObject oj2;
	public GameObject tho;

	float distance;
	public

    void Start()
    {	
		myRigidBody = this.tho.GetComponent<Rigidbody2D>();


    }

    void Update()
    {
		MovePlayer(myRigidBody,speed);	 
		MovePlayer(myRigidBody2,speed);	 
		distance = Vector3.Distance (myRigidBody.transform.position, oj2.transform.position);
		Debug.Log ("------------>"+ distance);
    }

	void MovePlayer(Rigidbody2D myRigidBody,float playerSpeed)
	{	
		if(distance >40){

			myRigidBody.velocity = new Vector3 (speed, myRigidBody.velocity.y, 0);

			speed = speedX2;
		}	if(distance >30 && distance<40){
			
			myRigidBody.velocity = new Vector3 (speed, myRigidBody.velocity.y, 0);
			speed = 3f;
		}
		if(distance >20 && distance<30){
			
			myRigidBody.velocity = new Vector3 (speed, myRigidBody.velocity.y, 0);
			speed = 3f;
		}
			if(distance >10 && distance<20){

			myRigidBody.velocity = new Vector3 (speed, myRigidBody.velocity.y, 0);
			speed = 10f;
		}
			if(distance >0 && distance <10){

			myRigidBody.velocity = new Vector3 (speed, myRigidBody.velocity.y, 0);
			speed = 15f;
		}

    }
}
