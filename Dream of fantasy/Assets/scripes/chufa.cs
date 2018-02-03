using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chufa : MonoBehaviour {
	//public GameObject xiao;
	public GameObject da;
	int k;
	void Start(){
		k = 0;
	}
	void OnTriggerEnter2D(Collider2D collidedObject){
		GameObject s = GameObject.Find ("S");
		GameObject longzi = GameObject.Find ("longzi");
		Destroy (s,4);
		Destroy (longzi);
		k = 1;
	}
	void Update(){
		if(k == 1)
		this.gameObject.transform.localScale = new Vector3(0.003f,0.003f,0)+this.gameObject.transform.localScale;
		if (this.gameObject.transform.localScale.x > 0.17) {
			Destroy (this.gameObject);
			da.SetActive (true);
			Destroy (da.gameObject, 5);
		}
	}

}