using UnityEngine;
using System.Collections;

public class LoopsPractice : MonoBehaviour {

	int specialNumber = 3;
	bool doWhileExp = false;

	// Use this for initialization
	void Start () 
	{
		/*
		while(specialNumber > 0)
		{
			Debug.Log ("Number = " + specialNumber);
			specialNumber--;
		}*/

		do
		{
			Debug.Log ("I'm going to run at least once regardless of the condition");
		}while(doWhileExp == true);


		for(int i = 0; i < specialNumber; i++)
		{
			Debug.Log("The number 'i' is below 3, therefore I will keep running");
		}



		string[] arrayOfStrings = new string[4];
		arrayOfStrings[0] = "First String";
		arrayOfStrings[1] = "Second String";
		arrayOfStrings[2] = "Third String";
		arrayOfStrings[3] = "Fourth String";

		foreach(string thingy in arrayOfStrings)
		{
			Debug.Log(thingy);
		}

	}

}
