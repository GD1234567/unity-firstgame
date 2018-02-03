using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huanrao : MonoBehaviour {
	public GameObject tt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
		//transform.RotateAround (tt.transform.position,5f);
		this.transform.RotateAround (tt.transform.position,new Vector3(0,0,5),2f);
	}
}
