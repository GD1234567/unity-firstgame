using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zimu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * 35 * Time.deltaTime);
	}
}
