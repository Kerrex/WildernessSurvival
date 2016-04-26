using UnityEngine;
using System.Collections;
using System;

public class WSADControl : MonoBehaviour {
	private bool isWPressed = false;
	private bool isSPressed = false;
	private bool isAPressed = false;
	private bool isDPressed = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		isWPressed |= Input.GetKeyDown (KeyCode.W);
		isWPressed &= !Input.GetKeyUp (KeyCode.W);
		isSPressed |= Input.GetKeyDown (KeyCode.S);
		isSPressed &= !Input.GetKeyUp (KeyCode.S);
		isAPressed |= Input.GetKeyDown (KeyCode.A);
		isAPressed &= !Input.GetKeyUp (KeyCode.A);
		isDPressed |= Input.GetKeyDown (KeyCode.D);
		isDPressed &= !Input.GetKeyUp (KeyCode.D);
		Move ();
	}

	void Move() {
		if (isWPressed) {
			if (Math.Abs (GetComponent<Rigidbody2D> ().velocity.y) < 2.0)
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 2), ForceMode2D.Force);				
		} else if (isSPressed) {
			if (Math.Abs (GetComponent<Rigidbody2D> ().velocity.y) < 2.0 )
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, -2), ForceMode2D.Force);
		} 
		if (isDPressed) {
			if (Math.Abs (GetComponent<Rigidbody2D> ().velocity.x) < 2.0 )
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (2, 0), ForceMode2D.Force);
		} else if (isAPressed) {
			if (Math.Abs (GetComponent<Rigidbody2D> ().velocity.x) < 2.0 )
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-2, 0), ForceMode2D.Force);
		}
	}


}
