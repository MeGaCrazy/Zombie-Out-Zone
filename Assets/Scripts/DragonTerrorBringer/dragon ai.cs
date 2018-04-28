using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon : MonoBehaviour 
{
	public Animator anim;
	int scream;
	int basicAttack;
	int clawAttack;
	int flameAttack;
	int defend;
	int getHit;
	int sleep;
	int walk;
	int run;
	int takeOff;
	int flyFlameAttack;
	int flyForward;
	int flyGlide;
	int land;
	int die;
	int idle02;

	void Awake () 
	{
		anim = GetComponent<Animator>();
		scream = Animator.StringToHash("Scream");
		basicAttack = Animator.StringToHash("Basic Attack");
		clawAttack = Animator.StringToHash("Claw Attack");
		flameAttack = Animator.StringToHash("Flame Attack");
		defend = Animator.StringToHash("Defend");
		getHit = Animator.StringToHash("Get Hit");
		sleep = Animator.StringToHash("Sleep");
		walk = Animator.StringToHash("Walk");
		run = Animator.StringToHash("Run");
		takeOff = Animator.StringToHash("Take Off");
		flyFlameAttack = Animator.StringToHash("Fly Flame Attack");
		flyForward = Animator.StringToHash("Fly Forward");
		flyGlide = Animator.StringToHash("Fly Glide");
		land = Animator.StringToHash("Land");
		die = Animator.StringToHash("Die");
		idle02 = Animator.StringToHash("Idle02");
	}


	public void Scream ()
	{
		anim.SetTrigger(scream);
	}

	public void BasicAttack ()
	{
		anim.SetTrigger(basicAttack);
	}

	public void ClawAttack ()
	{
		anim.SetTrigger(clawAttack);
	}

	public void FlameAttack ()
	{
		anim.SetTrigger(flameAttack);
	}

	public void Defend ()
	{
		anim.SetTrigger(defend);
	}

	public void GetHit ()
	{
		anim.SetTrigger(getHit);
	}

	public void Sleep ()
	{
		anim.SetTrigger(sleep);
	}

	public void Walk ()
	{
		anim.SetTrigger(walk);
	}

	public void Run ()
	{
		anim.SetTrigger(run);
	}

	public void TakeOff ()
	{
		anim.SetTrigger(takeOff);
	}

	public void FlyFlameAttack ()
	{
		anim.SetTrigger(flyFlameAttack);
	}

	public void FlyForward ()
	{
		anim.SetTrigger(flyForward);
	}

	public void FlyGlide ()
	{
		anim.SetTrigger(flyGlide);
	}

	public void Land ()
	{
		anim.SetTrigger(land);
	}

	public void Die ()
	{
		anim.SetTrigger(die);
	}

	public void Idle02 ()
	{
		anim.SetTrigger(idle02);
	}
	
}
