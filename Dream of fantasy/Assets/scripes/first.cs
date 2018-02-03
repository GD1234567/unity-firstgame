using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first : MonoBehaviour {
	public GameObject dian1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "zidan") {
			//Destroy (this.gameObject);
			this.gameObject.name = "qq";
			Destroy (dian1.gameObject);
		}
	}
}
