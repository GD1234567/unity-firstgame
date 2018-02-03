using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {
	public AudioClip one;
	// Use this for initialization
	void Start () {
		AudioSource.PlayClipAtPoint (one,this.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
