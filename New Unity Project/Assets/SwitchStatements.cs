using UnityEngine;
using System.Collections;

public class SwitchStatements : MonoBehaviour {


	public int comparedVariable = 3;

	void Start () 
	{
		SwitchFunction ();
	}
	

	void Update () {
	
	}

	void SwitchFunction()
	{
		switch (comparedVariable)
		{
		case 3:
			print ("hi");
			break;
		case 2:
			print ("hey");
			break;
		case 1:
			print ("SUP");
			break;
		default:
			print ("Hello");
			break;
		}
	}
}
