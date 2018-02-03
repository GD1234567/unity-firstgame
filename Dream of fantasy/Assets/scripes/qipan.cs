using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qipan : MonoBehaviour {
	public GameObject lssm;
	int ww = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerExit2D(Collider2D col){
		if (col.gameObject.tag == "player"){
			col.gameObject.GetComponent<PlayerShoot> ().enabled = true;
			col.gameObject.GetComponent<zhadan> ().enabled = false;
	}
	}
	//void OnTriggerEnter2D(Collider2D col){
		void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "player"){
			ww = ww + 1;
			if (ww == 1)
				lssm.SetActive (true);
			col.gameObject.GetComponent<PlayerShoot> ().enabled = false;
			col.gameObject.GetComponent<zhadan> ().enabled = true;
		}
	}
}
