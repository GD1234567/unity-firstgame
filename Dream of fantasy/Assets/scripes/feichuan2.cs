﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class feichuan2 : MonoBehaviour {
	public int sudu; 
	public GameObject player;
	public GameObject zhantai;
	void Start () {
		sudu = 0;
	}
	void Update () {
		transform.Translate(Vector3.right * sudu * Time.deltaTime);
		if (zhantai.name == "over")
		{//GameObject player = GameObject.Find ("player");
			sudu = 6;
	}
	}
	void OnTriggerEnter2D(Collider2D collidedObject){
		yiqizou ();
		Destroy (this.gameObject);
	}
	void yiqizou(){
			player.transform.parent = this.transform;
	}
} 

