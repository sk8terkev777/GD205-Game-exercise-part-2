﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {

	public GameObject mover;
	public int movementAmt =1;
	public Vector3 startingPosition;
	public GameObject winSpot;
	public Vector3 Winner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// check is mover's transform.position.* is beyond each threshold
		if (mover.transform.position.z < -4 || // is it behind the grid?
		    mover.transform.position.z > 4 || // is it too far off the grid?
		    mover.transform.position.x < -4 || // is it too far to the left of the grid?
		    mover.transform.position.x > 5) { // is it too far to the right of the grid?
			mover.transform.position = startingPosition; // is any of these are true....reste it's position to the startingPosition.
		}


			

	
		

		    





      
		
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Debug.Log ("Space bar pressed down");
			mover.transform.position += new Vector3 (0,0,-movementAmt);
		} else {
			Debug.Log ("false");
		}
	

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Debug.Log ("Space bar pressed down");
			mover.transform.position += new Vector3 (0,0,movementAmt);
		} else {
			Debug.Log ("false");
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Debug.Log ("Space bar pressed down");
			mover.transform.position += new Vector3 (movementAmt, 0, 0);
		} else {
			Debug.Log ("false");
		}


	
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Debug.Log ("Space bar pressed down");
			mover.transform.position += new Vector3 (-movementAmt, 0, 0);
		} else {
			Debug.Log ("false");
		}
	
	
	
	
	}
}
