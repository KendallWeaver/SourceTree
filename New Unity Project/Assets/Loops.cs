using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

	int specialNumber = 3;
	bool doWhileExp = false;

	// Use this for initialization
	void Start () 
	{/*
		while (specialNumber > 0) 
		{
			Debug.Log ("Cool");
			specialNumber--;
		}
	*/
		/*
		do {
			Debug.Log ("Runs at least once");
		} while (doWhileExp == true); */

		/*
		for(int i = 0; i < specialNumber; i++)
		{
			Debug.Log (i);
		}*/

		string[] arrayOfStrings = new string[4];
		arrayOfStrings[0] = "First String";
		arrayOfStrings[1] = "Second String";
		arrayOfStrings[2] = "Third String";
		arrayOfStrings[3] = "Fourth String";

		foreach(string array in arrayOfStrings)
		{
			Debug.Log (array);
		}
	}

}
