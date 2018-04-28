using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour {

    static Animator anim;
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        float ztranslation = Input.GetAxis("Vertical") * speed;
        float xtranslation = Input.GetAxis("Horizontal") * speed; 

        xtranslation *= Time.deltaTime;
        ztranslation *= Time.deltaTime;
        transform.Translate(xtranslation, 0, ztranslation);

        if (ztranslation != 0 || xtranslation != 0)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
        }
        else
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isIdle", true);
        }

        if (Input.GetButton("Fire1"))
        {
            anim.SetBool("isAttacking", true);
        }
        else
        {
            anim.SetBool("isAttacking", false);
        }

        

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

	}
}
