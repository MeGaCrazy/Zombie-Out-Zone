using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public Transform target;
	public float smoothing =5f;
	Vector3 offset;
	Vector3 offsetRotation;
	public bool lootAtPlayer=true;
	void Start(){
		offset = transform.position- target.position;
	}
	void FixedUpdate(){	
		Vector3 targetCampos = target.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetCampos, smoothing * Time.deltaTime);
	}

}
