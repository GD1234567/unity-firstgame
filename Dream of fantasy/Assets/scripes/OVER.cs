using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OVER : MonoBehaviour {
	// Use this for initialization
	public GameObject fire;
	public GameObject s;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter2D(Collider2D other){
		//GameObject p = GameObject.Find ("player");
		if (other.gameObject.tag=="player"){
		other.gameObject.GetComponent<playermove>().enabled = false;
			other.gameObject.GetComponent<PlayerShoot>().enabled = false;
		GameObject lasts = GameObject.Instantiate (s);
		lasts.transform.position=new Vector3(-2.8f,54.8f,0f);
		GameObject s1 = GameObject.Find ("map1");
		Destroy (s1);
		GameObject s2 = GameObject.Find ("MAP2");
		Destroy (s2);
		GameObject s3 = GameObject.Find ("MAP3");
		Destroy (s3);
		GameObject fire1 = GameObject.Instantiate (fire);
		fire.transform.position=new Vector3(-2.6f,53f,0f);
		Destroy (fire1,0.35f);
		GameObject fire2 = GameObject.Instantiate (fire);
		fire.transform.position=new Vector3(0.12f,51f,0f);
		Destroy (fire2,0.35f);
		GameObject fire3 = GameObject.Instantiate (fire);
		fire.transform.position=new Vector3(2.4f,52f,0f);
		Destroy (fire3,0.35f);
		GameObject s4 = GameObject.Find ("MAP4");
		Destroy (s4);
		this.gameObject.name = "over";
		//s.enable = true;
		}
}
}
