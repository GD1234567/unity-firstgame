using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;
public class kaichang : MonoBehaviour {
	public GameObject logo;
	public float sudu1;
	public float sudu2;
	// Use this for initialization
	void Start () {
		sudu1 = 0f;
		sudu2 = 3f;
	}
	
	// Update is called once per frame
	void Update () {
		logo.transform.Rotate (0,0,sudu1);
		transform.Translate(Vector3.left * sudu2 * Time.deltaTime);
	}
	void OnTriggerEnter2D(Collider2D collidedObject){
		sudu1 = 0;
		sudu2 = 0;
		SceneManager.LoadScene ("first");

	}
}
