using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour {

	public int startingHealth;
	public int currentHealth;
	public float sinkSpeed = 2.5f;
	public int scoreValue = 10;


	Animator anim;
	ParticleSystem hitParticles;
	CapsuleCollider capsuleCollider;
	bool isDead;
	bool isSinking;

	private void Awake()
	{
		anim = GetComponent<Animator>();
		hitParticles = GetComponentInChildren<ParticleSystem>();
		capsuleCollider = GetComponent<CapsuleCollider>();
		currentHealth = startingHealth;
	}
	private void Update()
	{
		if (isSinking)
		{
			transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
		}
	}


	public void TakeDamage(int amount, Vector3 hitPoint)
	{
		if (isDead)
			return;
		currentHealth -= amount;
		hitParticles.transform.position = hitPoint;
		hitParticles.Play();

		if (currentHealth <= 0)
		{
			Death();
		}
	}

	void Death()
	{
		isDead = true;
		capsuleCollider.isTrigger = true;
		anim.SetBool("dead", true);
	}


	public void StartSinking()
	{
		GetComponent<Rigidbody>().isKinematic = true;
		isSinking = true;
		Destroy(gameObject, 2f);
	}

}
