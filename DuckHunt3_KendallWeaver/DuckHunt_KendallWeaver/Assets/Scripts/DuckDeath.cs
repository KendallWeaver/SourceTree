using UnityEngine;
using System.Collections;

public class DuckDeath : MonoBehaviour {

	public Animator anim;
	
	bool invisible;
	
	// Use this for initialization
	void Start () 
	{
		// Get Component to get animator and assign to anim
		GameManager.OnDuckMiss += MakeInvincible;
		GameManager.OnDuckShot += MakeInvincible;
	}
	
	// Update is called once per frame
	//void Update () {
	//
	//}
	
	
	void OnTriggerEnter(Collider hit)
	{
		if (hit.tag == "KillZone")
		{
			GameManager.OnDuckDeath();
			Destroy(this.gameObject);
		}
		
		if (hit.tag == "FlyAway")
		{
			GameManager.OnDuckFlyAway();
			Destroy(this.gameObject);
		}
	}
	
	public void KillDuck()
	{
		if (invisible == false)
		{
			anim.Play("BlackDuckDie");
			GameManager.OnDuckShot();
		}
	}
	
	public void MakeInvincible()
	{
		invisible = true;
	}
}
