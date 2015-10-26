using UnityEngine;
using System.Collections;

public class Enumeration : MonoBehaviour {

	enum Testing {Value1, Value2, Value3};

	void Start () 
	{
		Testing variableTesting;
		variableTesting = Testing.Value1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	Testing Function (Testing test)
	{
		return test;
	}
}
