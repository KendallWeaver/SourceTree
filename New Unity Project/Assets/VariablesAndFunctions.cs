using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour {

	int theInt = 5;
	const int TWO = 2;

	// Use this for initialization
	void Start () {
		theInt = MultiplyByTwo (theInt);
		Debug.Log (theInt);
	}
	
	int MultiplyByTwo (int number) 
	{
		int ret;
		ret = number * TWO;
		return ret;
	}
}
