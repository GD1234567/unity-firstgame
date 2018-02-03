using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setactive : MonoBehaviour {
	public int g;
	public GameObject key;
	// Use this for initialization
	void Start () {
		//GameObject key = GameObject.Find ("key");
		key.SetActive (false);
		g = 0;
	}
	
	// Update is called once per frame
	void Update () {
		g = g + 1;
		if (g % 8 == 0)
			key.SetActive (true);
		else
			key.SetActive (false);
		
	}
}
