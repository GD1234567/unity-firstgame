﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * 4 * Time.deltaTime);
	}
}
