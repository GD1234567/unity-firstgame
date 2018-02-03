using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guanka : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag=="fish"){
		GameObject ss = GameObject.Find ("ss");
		Destroy (this.gameObject,0.5f);
		Destroy (ss,0.5f);
	col.transform.GetComponent<SpriteRenderer> ().sortingOrder = 2;
			Destroy (col.transform.GetComponent<Rigidbody2D>());
			Destroy (col.transform.GetComponent<BoxCollider2D>());
		}
}
}
