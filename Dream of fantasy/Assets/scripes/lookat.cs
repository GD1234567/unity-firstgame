using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour {
	public GameObject zhujiao;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//zhujiao = GameObject.Find ("player");
		this.gameObject.transform.LookAt (zhujiao.transform,Vector3.up);
	}
}
