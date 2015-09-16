using UnityEngine;
using System.Collections;

public class IFStatements : MonoBehaviour {
	//Variables
	public float coffeeTemp = 85.0f;
	public float hotLimitTemp = 70.0f;
	public float coldLimitTemp = 40.0f;

	void Start () 
	{

	}

	void Update () 
	{
		// Code that will deliver input when a key is pressed
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		// Code that will change temp over time
		coffeeTemp -= Time.deltaTime * 5f;
	}

	// New Function
	public void TemperatureTest()
	{
		if (coffeeTemp >= hotLimitTemp)
		{
			Debug.Log ("Too hot");
		}
		else if (coffeeTemp <= coldLimitTemp)
		{
			Debug.Log ("Too cold");
		}
		else
		{
			Debug.Log ("Perfection");
		}
	}
}
