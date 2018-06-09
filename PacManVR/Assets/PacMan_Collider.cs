using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan_Collider : MonoBehaviour {

	public float heightOffset, radius, centerScale;
	public CapsuleCollider collider;

	// Use this for initialization
	void Start () {
		gameObject.AddComponent<CapsuleCollider> ();
		collider = GetComponent<CapsuleCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
		collider.radius = radius;
		collider.isTrigger = true;
		collider.height = transform.position.y  - heightOffset;
		collider.center = new Vector3 (0, -transform.position.y/2 - heightOffset, 0);
	}

	public void OnTriggerEnter(Collider col) {
		if (col.tag == "Ghost") {
			//TODO
		}
	}
}
