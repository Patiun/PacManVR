using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour {

	public Ghost[] ghosts;
	public float maxGhosts;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 1; i <= maxGhosts; i++) {
			if (Input.GetKeyDown("joystick "+i+" button 9")) {
				Debug.Log ("Boo " + i);
				if (!ghosts [i-1].gameObject.activeInHierarchy) {
					ghosts [i-1].gameObject.SetActive (true);
				}
			}
		}
	}
}
