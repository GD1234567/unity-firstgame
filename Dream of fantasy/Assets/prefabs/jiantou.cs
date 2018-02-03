using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jiantou : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (GameObject.Find ("ZT") != null) {
		//GameObject ZT = GameObject.Find ("ZT");
		this.gameObject.transform.localScale = this.gameObject.transform.localScale + new Vector3(0.01f,0.01f,0.01f);
		if (this.gameObject.transform.localScale.x > 0.4f)
			Destroy (this.gameObject);
		//}
	}
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "ZHADAN")
			Destroy (col.gameObject);
	}
}
