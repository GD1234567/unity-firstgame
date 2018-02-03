using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laohu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * 4 * Time.deltaTime);
	}
}
