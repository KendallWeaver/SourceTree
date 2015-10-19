using UnityEngine;
using System.Collections;

public class Array : MonoBehaviour {

	public int[] practiceArray = {5, 6, 9, 7, 8};

	void Start () 
	{
		for(int i = 0; i < practiceArray.Length; i++)
		{
			Debug.Log("Sequence "+i +" contains the number "+practiceArray[i]);
		}
	}

	void Update () 
	{

	}
}
