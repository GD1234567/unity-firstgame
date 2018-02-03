using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logochufa : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D collidedObject){
		GameObject s = GameObject.Find ("player");
		transform.parent=s.transform;
	}
}
