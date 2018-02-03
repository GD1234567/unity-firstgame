using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class zidanxiaoguo : MonoBehaviour {
	public GameObject yw;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//void OnTriggerEnter2D(Collider2D other)
	void OnCollisionEnter2D(Collision2D other)
	{  
		if (other.gameObject.tag == "zidan") {
			Destroy (other.gameObject);
			//Destroy (this.gameObject);
			GameObject yw1 = GameObject.Instantiate (yw);
			yw1.transform.position = new Vector3 ((this.transform.position.x)-0.25f, this.transform.position.y, this.transform.position.z);
			Destroy (yw1, 0.5f);
		}
	}
}
