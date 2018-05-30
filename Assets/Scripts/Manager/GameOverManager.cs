using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	public float restartDelay=3f;

    Animator anim;
	float restartTimer;
	public Text text;
	private Transform input1;

    void Awake()
	{
		anim = GetComponent<Animator> ();
		text = GetComponentInChildren<Text> ();
		input1 = transform.parent.Find ("MobileInputs");
	}

    void Update()
    { 
		

		if (playerHealth.currentHealth <= 0) {
			input1.gameObject.SetActive (false);
			anim.SetTrigger ("GameOver");
			restartTimer += Time.deltaTime;
			if (restartTimer >= restartDelay) {
				SceneManager.LoadScene ("Menu");
			}
		} else if (ScoreManager.score>=80) {
			input1.gameObject.SetActive (false);
			text.text = "Victory!!";
			anim.SetTrigger ("GameOver");
			restartTimer += Time.deltaTime;
			if (restartTimer >= restartDelay) {
				SceneManager.LoadScene ("Menu");
			}
		}
    }
}
