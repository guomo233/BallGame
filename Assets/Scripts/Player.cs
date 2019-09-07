using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 5f ;

	private Rigidbody rb ;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.UpArrow))
			rb.AddForce (Vector3.forward * speed, ForceMode.Force);
		if (Input.GetKey (KeyCode.DownArrow))
			rb.AddForce (Vector3.back * speed, ForceMode.Force);
		if (Input.GetKey (KeyCode.LeftArrow))
			rb.AddForce (Vector3.left * speed, ForceMode.Force);
		if (Input.GetKey (KeyCode.RightArrow))
			rb.AddForce (Vector3.right * speed, ForceMode.Force);
	}

	void OnCollisionEnter (Collision coll) {
		if (coll.gameObject.tag == "WoodBall" ||
			coll.gameObject.tag == "StoneBall" ||
			coll.gameObject.tag == "PaperBall") {

			float new_mass = coll.gameObject.GetComponent<Rigidbody> ().mass;
			rb.mass = new_mass;

			Material new_mat =  coll.gameObject.GetComponent<Renderer> ().material;
			GetComponent<Renderer> ().material = new_mat;

			tag = coll.gameObject.tag ;

			transform.localScale = Vector3.one;
		}
	}
}
