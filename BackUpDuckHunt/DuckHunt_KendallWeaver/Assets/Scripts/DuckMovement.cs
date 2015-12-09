using UnityEngine;
using System.Collections;

public class DuckMovement : MonoBehaviour {

	public float speed;
	public Vector3 direction;

	// Use this for initialization
	void Start () 
	{
		RandomDir ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		// move duck; change position of transform * direction with speed
		transform.Translate (direction * speed);
	}

	public void RandomDir()
	{
		direction = new Vector3 (Random.Range (-1f, 1f), Random.Range (.2f, 1f), 0);
	}

	public void DirectionChanges(Vector3 _dir)
	{
		direction = new Vector3 (direction.x * _dir.x, direction.y * _dir.y, 0);
	}
}
