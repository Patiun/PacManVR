using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {

	public float speed;
	public int playerID;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("joystick "+playerID+" button 9")) {
			Debug.Log ("Boo");
		}
		rb.velocity = new Vector3 (Input.GetAxis ("GhostHorizontal_"+playerID), 0, Input.GetAxis ("GhostVertical_"+playerID)).normalized * speed;
	}
}
