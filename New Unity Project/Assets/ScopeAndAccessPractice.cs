using UnityEngine;
using System.Collections;

public class ScopeAndAccessPractice : MonoBehaviour {
	// In Scope of the Class
	// Variables in Class have an access modifier (public/private)
	// and defines where it can be seen from
	public int alpha = 29;
	private int beta = 0;

	//Accessing Another Class
	private ScopeAndAccess otherClass;

	// Use this for initialization
	void Start () 
	{
		// Referencing another class
		//otherClass = new ScopeAndAccess ();
		//otherClass.TestingFunction ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Local to Function
		int omega = 5;
	
	}

	public void TestingFunction()
	{
		int imInsideTheTestingFunction = 6;
	}
}
