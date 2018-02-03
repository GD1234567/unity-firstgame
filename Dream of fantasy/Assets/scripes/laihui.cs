using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laihui : MonoBehaviour {
	public GameObject aa;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag=="player")
		aa.SetActive (false);
}
	void OnTriggerExit2D(Collider2D col){
		if (col.gameObject.tag=="player")
		aa.SetActive (true);
	}
}
