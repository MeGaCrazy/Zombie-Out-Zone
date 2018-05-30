using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour {

    public Transform player;
    public PlayerHealth ph;
    static Animator anim;
    public detectHit dethit;
    public float timeBetweenAttacks = 1000f;
    public int attackDamage = 10;
    float timer;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if (dethit.currentHealth > 0)
        {
            Vector3 direction = player.position - this.transform.position;
            float angle = Vector3.Angle(direction, this.transform.forward);
            if (Vector3.Distance(player.position, this.transform.position) < 50 && angle < 360)
            {

                direction.y = 0;
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);


                anim.SetBool("isIdle", false);
                if (direction.magnitude > 7)
                {
                    this.transform.Translate(0, 0, 0.05f);
					anim.SetBool("isAttacking", false);
                    anim.SetBool("isWalking", true);
                    
                }
                else
                {
                     timer += Time.deltaTime;
                    if(timer >= timeBetweenAttacks /* && enemyHealth.currentHealth > 0*/){
						anim.SetBool("isAttacking", true);
						anim.SetBool("isWalking", false);
						ph.TakeDamage(10);
						timer = 0f;
                   }
                }
            }
            else
            {
                anim.SetBool("isIdle", true);
                anim.SetBool("isWalking", false);
                anim.SetBool("isAttacking", false);
            }
        }
        else
        {
            anim.SetBool("isDead", true);
        }
	}
}
