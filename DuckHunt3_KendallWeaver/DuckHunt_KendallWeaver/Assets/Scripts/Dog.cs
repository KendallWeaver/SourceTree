using UnityEngine;
using System.Collections;

public class Dog : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () 
	{
		// GetComponent to get the animator
		GameManager.OnDuckDeath += PlayDuck;
		GameManager.OnDuckFlyAway += Laugh;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public void SpawnDucks()
	{
		GameManager.OnSpawnDucks();
	}
	
	public void Laugh()
	{
		anim.Play("DogLaughing");
	}
	
	public void PlayDuck()
	{
		anim.Play("DuckHoldingOneDuck");
	}
}
