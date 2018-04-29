using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plapla : MonoBehaviour {
      
	public Transform player;
	public PlayerHealth ph;
	static Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = player.position - this.transform.position;
		float angle = Vector3.Angle(direction, this.transform.forward);
		if(Vector3.Distance(player.position, this.transform.position) < 50 && angle < 180)
		{
			
            
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);


            anim.SetBool("issleep", true);
            if(Vector3.Distance(player.position, this.transform.position) > 20 && angle < 180)
            {
                this.transform.Translate(0, 0, 0.3f);
                anim.SetBool("isrun", true);
                anim.SetBool("isattacke", false);
            }
            else
            {
                anim.SetBool("isattacke", true);
                anim.SetBool("isrun", false);
                ph.TakeDamage(5);

            }
		}
		else
		{
			anim.SetBool("issleep", false);
		}
	}
}
