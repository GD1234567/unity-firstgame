using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yushui : MonoBehaviour {
	//public Object[] yu = null;
	public GameObject yu;
	public GameObject caoyuan1;
	public GameObject caoyuan2;
	GameObject yu1;
	public AudioClip ys;
	public float num = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {		
		if (GameObject.Find ("niu") == null)
		if(num< 100)
		{num = num + 0.5f;
			if (num > 50)
				caoyuan1.SetActive (true);
			if (num > 95)
				caoyuan2.SetActive (true);
			if(num < 1)
				AudioSource.PlayClipAtPoint (ys,transform.position);
			 yu1 = GameObject.Instantiate (yu);
		yu1.transform.position = new Vector3 (Random.Range (3.8f, 13.5f), Random.Range (54, 63.5f), 0);
			Destroy (yu1,0.7f);
	}
}
}
