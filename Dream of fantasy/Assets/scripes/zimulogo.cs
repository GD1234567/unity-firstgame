using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zimulogo : MonoBehaviour {
	public int daole;
	// Use this for initialization
	void Start () {
		daole = 35;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * daole * Time.deltaTime);
	}
	void OnTriggerEnter2D(Collider2D collidedObject){
		daole = 0;
	}
}
