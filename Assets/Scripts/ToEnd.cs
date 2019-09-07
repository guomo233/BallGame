using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToEnd : MonoBehaviour {

	private GameObject player ;
	private GameControl gameControl ;

	// Use this for initialization
	void Start () {
		gameControl = GameObject.Find ("GameControler").GetComponent<GameControl> ();
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider coll) {
		if (coll.gameObject == player) {
			gameControl.restart ();
		}
	}
}
