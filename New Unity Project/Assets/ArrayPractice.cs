using UnityEngine;
using System.Collections;

public class ArrayPractice : MonoBehaviour {
	// basic array
	//int[] practiceArray = new int[6];

	//Initializing the array in one line
	// Adding public makes it available in the Inspector
	public int[] practiceSingleArray = {9, 13, 192, 9048, 023834, 56};

	void Start () 
	{
		/* Initializing All of the arrays
		practiceArray [0] = 9;
		practiceArray[1] = 13;
		practiceArray[2] = 192;
		practiceArray[3] = 9048;
		practiceArray[4] = 023834;
		practiceArray[5] = 56;

		Debug.Log ("Display the second Array number: " + practiceArray[1]);
		*/
		
		// Checking to see if the single Array line worked
		//Debug.Log ("Display the third Array number: " + practiceSingleArray[2]);

		//Using Arrays in Loops
		for(int i = 0; i < practiceSingleArray.Length; i++)
		{
			Debug.Log("Sequence Number "+i +" in the Array contains the number " +practiceSingleArray[i]);
		}

	}
	

	void Update () 
	{

	}
}
