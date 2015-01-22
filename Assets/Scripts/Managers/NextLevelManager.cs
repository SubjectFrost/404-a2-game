using UnityEngine;

public class NextLevelManager : MonoBehaviour
{
	public PlayerHealth playerHealth;
	
	
	Animator anim;
	
	
	void Awake()
	{
		anim = GetComponent<Animator>();
	}
	
	
	void Update()
	{
		if (playerHealth.currentHealth <= 50)
		{
			anim.SetTrigger("NextLevel");
		}
	}
}
