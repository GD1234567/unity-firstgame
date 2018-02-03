using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zz : MonoBehaviour {
	public GameObject bb1;
	public GameObject bb2;
	public GameObject bb3;
	public GameObject bb4;
	public GameObject pp;
	public GameObject qiao;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (bb1.name == "qq" && bb2.name == "qq" && bb3.name == "qq" && bb4.name == "qq") {
			transform.Translate (new Vector3(1,4,0)* 2 * Time.deltaTime);
			Destroy (this.gameObject,0.6f);
			qiao.SetActive (true);
			Destroy (pp.gameObject);
		}
	}
}
