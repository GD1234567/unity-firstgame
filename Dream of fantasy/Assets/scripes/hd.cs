using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3(-2,0,0)* 2 * Time.deltaTime);
	}
}
