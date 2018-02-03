using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changjin3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		//GameObject s = GameObject.Find ("player");
		//Destroy (s);
		//Destroy (col.gameObject);
		SceneManager.LoadScene ("666");
	}
}
