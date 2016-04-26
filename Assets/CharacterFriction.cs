using UnityEngine;
using System.Collections;

public class CharacterFriction : MonoBehaviour {
	public Vector2 force;
	private bool isWPressed = false;
	private bool isSPressed = false;
	private bool isAPressed = false;
	private bool isDPressed = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CheckForKeyDownsAndUps ();
		Friction ();
	}

	void CheckForKeyDownsAndUps() {
		isWPressed &= !Input.GetKeyUp (KeyCode.W);
		isWPressed |= Input.GetKeyDown (KeyCode.W);
		isSPressed &= !Input.GetKeyUp (KeyCode.S);
		isSPressed |= Input.GetKeyDown (KeyCode.S);
		isAPressed &= !Input.GetKeyUp (KeyCode.A);
		isAPressed |= Input.GetKeyDown (KeyCode.A);
		isDPressed &= !Input.GetKeyUp (KeyCode.D);
		isDPressed |= Input.GetKeyDown (KeyCode.D);
	}

	void Friction() {
		Vector2 velocity = GetComponent<Rigidbody2D> ().velocity;
		if (!isWPressed && !isSPressed) {
			if (velocity.y < 0)
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, force.x));
			else if (velocity.y > 0)
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, -force.x));
		}
		if (!isAPressed && !isDPressed) {
			if (velocity.x < 0)
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (force.y, 0));
			else if (velocity.x > 0)
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-force.y, 0));
			
		}
		print (velocity);
	}
}
