using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform player ;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player").transform;
		offset = transform.position - player.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = offset + player.position;
	}
}
