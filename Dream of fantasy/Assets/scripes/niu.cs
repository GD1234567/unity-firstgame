using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niu : MonoBehaviour {
public GameObject tt;
	int a = 0;
	public GameObject sss;
	void Start () {
		//GameObject tt = GameObject.Find ("shuzhuang");	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.RotateAround (tt.transform.position,new Vector3(0,0,0.5f),1f);
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag=="cao"){
			a = a + 1;
			if (a == 1) {
				this.transform.RotateAround (tt.transform.position, new Vector3 (0, 0, 0.5f), -1f);
				Destroy (other.gameObject);
			} else {
				Destroy (this.gameObject);
				Destroy (other.gameObject);
				Destroy (sss);
			}
		}
	}
}
	
