using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sm : MonoBehaviour {
	public GameObject ssm;
	//public GameObject an;
	int f;
	// Use this for initialization
	void Start () {
		f = 0;
		GameObject btnObj1 = GameObject.Find ("Canvas/sm");
		Button btn1 = (Button)btnObj1.GetComponent<Button> ();
		btn1.onClick.AddListener (onClick);

	}
	
	// Update is called once per frame
	void Update () {
		if (f == 0)
			ssm.SetActive (false);
		else
			ssm.SetActive (true);
	}
	void onClick(){
		if (f == 0)
			f = 1;
		else
			f = 0;
	}

}
