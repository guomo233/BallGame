using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn : MonoBehaviour {

	public float dead_scale = 0.1f ;

	private GameObject player;
	private GameControl gameControl ;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		gameControl = GameObject.Find ("GameControler").GetComponent<GameControl> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider coll) {
		if (coll.gameObject == player) {
			InvokeRepeating ("burn", 0f, 0.1f);
		}
	}

	void OnTriggerExit (Collider coll) {
		if (coll.gameObject == player) {
			CancelInvoke ();
		}
	}

	void burn() {
		float speed = 1f ;
		if (player.tag == "WoodBall")
			speed = 0.99f;
		else if (player.tag == "PaperBall")
			speed = 0.9f;
		
		player.transform.localScale *= speed ;

		if (player.transform.localScale.x <= dead_scale)
			gameControl.restart ();
	}
}
