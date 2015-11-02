using UnityEngine;
using System.Collections;

public class SwitchStatementPractice : MonoBehaviour 
{

	// Switch statement compares a single variable to a series of constants.
	// Make decisions based on enumerations

	/* NOT USED
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}*/

	// Create an int

	public int intelligence = 5;

	// Create a function
	// Will output a greeting based on intelligence

	void Greet()
	{
		// Switch will be comparing the variable in intelligence
		switch (intelligence) 
		{
			// Define a series of cases (constants)
		case 5:
			print ("Greeting and salutations, my friend.");
			// break is a keyword that jumps the code if the switch is "true"
			break;
			// Since it's in the switch statement, it will jump out and continue executing outside the switch
		case 4:
			print ("Why, hello there!");
			break;
		case 3:
			print ("Hi");
			break;
		case 2:
			print ("Hey");
			break;
		case 1:
			print ("SUP.");
			break;
			// catch everything outside of the case
		}
	}
}
