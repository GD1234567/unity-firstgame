using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lss : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "player")
		{ GameObject s = GameObject.Find ("dianji");
			Destroy (s);
			Destroy (this.gameObject);}
	}
}
