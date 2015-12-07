using UnityEngine;
using System.Collections;

public class ChangeDirectionScript : MonoBehaviour {

	public enum DirectionChanger{Horizntal, Vertical};
	public DirectionChanger change;

	// Use this for initialization
	void Start () {

		// GameManager.OnDuckShot += TurnOff;
		// GameManager.OnDuckMiss += TurnOn;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision hit)
	{
		if (hit.transform.tag == "Duck") 
		{
			// create duckmovement variable. Assign with GetComponent of hit
			// GetComponent<>();
			DuckMovement movement = hit.transform.GetComponent<DuckMovement>();

			if (change == DirectionChanger.Horizntal)
			{
				// Take duckmovement variable and call the DirectionChanges function. Pass in a new Vector3(-1f, 1f, 0)
				movement.DirectionChanges(new Vector3(-1f, 1f, 0));
			}
			else if(change == DirectionChanger.Vertical)
			{
				// Take duckmovement variable and call the DirectionChanges function. Pass in a new Vector3(1f, -1f, 0)
				movement.DirectionChanges(new Vector3 (1f, -1f, 0));
			}
		}
	}

	public void TurnOff()
	{
		gameObject.SetActive (false);
	}

	public void TurnOn()
	{
		gameObject.SetActive (true);
	}
}
