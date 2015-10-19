using UnityEngine;
using System.Collections;

public class DataTypesPractice : MonoBehaviour {

	// Various Kinds of values
	// int, float, double, bool, char, Structs(Vector3 Quaternion)

	// Reference
	// Classes (common classes: Transform, GameObject)
	// Subclass
	public class Stuff
	{
		// Variable
		public int someStuff;
		// Default vs Paramaterized Constructors
		// Default
		public Stuff()
		{
			someStuff = 5;
		}

		// Parameter
		public Stuff(int thingy)
		{
			someStuff = thingy;
		}
	}

	//Instance of the Subclass as an object
	// public Stuff myStuff = new Stuff();
	// With Parameters
	public Stuff myStuff = new Stuff(6);
	// Brackets at the end imply constructor
	// Constructor is a Function that you can use to give default values to other variables in your class

	// Value type variables contain a value
	// Reference types contain a memory address where the value is stored
	// When value type changes, it changes only that value
	// When Reference types changes, it changes all the variables that contain that memory

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Variable
	/*	Vector3 pos = transform.position;
		pos = new Vector3 (0,2,0);

		// Reference
		Transform tran = transform;
		tran.position = new Vector3 (0,2,0); */
	}
}
