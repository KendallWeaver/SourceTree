using UnityEngine;
using System.Collections;

public class IFStatementsPractice : MonoBehaviour {

	public float coffeeTemp = 85.0f;
	public float hotLimitTemp = 70.0f;
	public float coldLimitTemp = 40.0f;

	void Start () 
	{
	
	}

	void Update () 
	{
	//Code that indicates what button to press to see the the IF Statement Results
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
	// Code that will decrease the temperatures over time
		coffeeTemp -= Time.deltaTime * 5f;
	}

	void TemperatureTest ()
	{
		if(coffeeTemp > hotLimitTemp)
		{
			Debug.Log ("This is too hot.");
		}
		else if(coffeeTemp < coldLimitTemp)
		{
			Debug.Log ("This is too cold.");
		}
		else
		{
			Debug.Log ("Perfection.");
		}
	}
}
