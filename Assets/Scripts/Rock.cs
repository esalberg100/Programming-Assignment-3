using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {
	
	// declare variables

	public float thrust;
	public Rigidbody2D rb;
	public Vector2 direction;
	private int rand;

	// Start function - initiated when rock spawns
	void Start ()
	{
		// generate random number
		rand = Random.Range (1, 5);	

		// default value
		direction = Vector2.one;						

		// check value of randon number
		if (rand == 1)									
			{

			// set direction based on value of rand
			direction = new Vector2(1f,1f);				
			}
			else if (rand == 2)
			{
			direction = new Vector2(-1f,1f);
			}
			else if (rand == 3)
			{
			direction = new Vector2(-1f,-1f);
			}
			else if (rand == 4)
			{
			direction = new Vector2(1f, -1f);
			}
		print (rand);									// for debugging
		direction = direction.normalized;				// set magnitude of vector to 1
		rb.AddForce (direction, ForceMode2D.Impulse);	// add force to rigidbody in set direction
	}
		

	void OnBecameInvisible () {							// check if off screen
		Debug.Log ("invisible");						// debugging
		Destroy (this.gameObject);						// destroy game object
	}
}
