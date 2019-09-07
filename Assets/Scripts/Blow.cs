using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blow : MonoBehaviour {

	public float power = 4f ;

	private GameObject player ;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay (Collider coll) {
		if (coll.gameObject == player) {
			Rigidbody player_rd = player.GetComponent<Rigidbody> ();
			player_rd.AddForce (Vector3.up * power, ForceMode.Force);
		}
	}
}
