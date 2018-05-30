using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {
	public float speed = 6f;
	Vector3 movement;
	Animator anim;
	Rigidbody playerRigidbody;
	private Transform CamTransform;
	Vector2 MoveVector;
	void Awake(){
		anim = GetComponent<Animator> ();
		playerRigidbody = GetComponent<Rigidbody> ();
	}
	void FixedUpdate(){
		float h = CrossPlatformInputManager.GetAxisRaw ("Horizontal");
		float v = CrossPlatformInputManager.GetAxisRaw ("Vertical");
		Move (h, v);
		RotateWithView();

	}
	void Move(float h,float v){
		movement.Set (h, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;
		playerRigidbody.MovePosition (transform.position + movement);
		//Rotate Our Camera
		MoveVector=RotateWithView();

		Animating (movement.magnitude);
		if (movement.magnitude >0) {
			Quaternion newDirection = Quaternion.LookRotation (movement);
			transform.rotation = newDirection;	
		}
	}
	void Animating(float mvspeed){
		bool walking = mvspeed>0;
		anim.SetBool ("isWalking", walking);
	}
	private Vector3 RotateWithView(){
		if (CamTransform != null) {
			Vector3 dir = CamTransform.TransformDirection (MoveVector);
			dir.Set (dir.x, 0, dir.z);
			return dir.normalized*MoveVector.magnitude;
		} else {
			CamTransform = Camera.main.transform;
			return MoveVector;
		}
	}
}
