﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class d : MonoBehaviour {
	public int sudu; 
	public GameObject player;
	public int JISHI; 
	void Start () {
		sudu = 5;
	}
	void Update () {
		transform.Translate(Vector3.right * sudu * Time.deltaTime);
		JISHI = JISHI + 1;
		if (JISHI > 210)
			sudu = 8;
	}
	//void OnBecomeInvisible(){
	//	Destroy (this.gameObject);
	//}
	void OnTriggerEnter2D(Collider2D collidedObject){
		//if (hit.gameObject.name == "ZD")
		sudu = 0;
		chanshen ();
		Destroy (this.gameObject,3f);
	}
	void chanshen(){
		if (this.transform.position.x<0.25f) {
		GameObject f = GameObject.Instantiate (player);
			f.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z);
			//p = GameObject.Find ("f");
			//p.SetActive(true);
		} else 
			return;
	}
} 
