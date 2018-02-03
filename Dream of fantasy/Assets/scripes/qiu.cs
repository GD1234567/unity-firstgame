using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qiu : MonoBehaviour {
	public AudioClip gu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other){
			AudioSource.PlayClipAtPoint (gu,transform.position);
		
	}
}
