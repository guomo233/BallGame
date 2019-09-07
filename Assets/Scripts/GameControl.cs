using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class GameControl : MonoBehaviour {

	public Vector3 init_position = Vector3.zero ;
//	public int init_life = 3;

	private GameObject player ;
//	private Text life_text ;
//	private int life ;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
//		life_text = GameObject.Find ("Life").GetComponent<Text> ();
//		life = init_life;

//		life_text.text = "Life: " + init_life.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.y < -3) {
			restart ();
		}
	}

	public void restart () {
//		if (life > 0) {
			player.transform.position = init_position;
			player.transform.localScale = Vector3.one;

//			life--;
//			life_text.text = "Life: " + life.ToString ();
//		} else {
//			Debug.Log ("Game over") ;
//		}
	}
}
