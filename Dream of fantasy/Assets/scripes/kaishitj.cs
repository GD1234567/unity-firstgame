using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaishitj : MonoBehaviour {
	public GameObject taijib;
	public int jd = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (jd < 180) {
			taijib.transform.Rotate (0, 0, 1);
			jd = jd + 1;
		}
		else
			this.gameObject.GetComponent<ww> ().enabled = true;
	}
}
