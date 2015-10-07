using UnityEngine;
using System.Collections;

public class DataTypes : MonoBehaviour 
{

	public class SubClass
	{
		public int var;

		public SubClass(int va)
		{
			var = va;
		}
	}

	public SubClass otherClass = new SubClass(4);
	public SubClass otherOtherClass = new SubClass(50);

	void Start () 
	{
		int firstInt;
		int secondInt;

		otherOtherClass = otherClass;
		firstInt = 8;
		secondInt = firstInt;
		otherOtherClass.var = 7;

		Debug.Log (otherClass.var);
		Debug.Log (firstInt);
	}


	void Update () 
	{

	}
}
