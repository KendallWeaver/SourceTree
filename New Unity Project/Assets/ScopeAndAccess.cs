using UnityEngine;
using System.Collections;

public class ScopeAndAccess : MonoBehaviour 
{

	public int aPublicVariable = 5;
	private int aPrivateVariable = 60;
	int anotherPrivateVariable = 8;

	private ScopeAndAccessPractice otherClass;

	void Start () 
	{
	
	}

	void Update () 
	{
		int itsNice = 0;
		otherClass = new ScopeAndAccessPractice ();
		otherClass.TestingFunction ();
	}

}
