using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
public class zanting : MonoBehaviour {
	int f;
	public Image zanting1;
	public Image kaishi;
	// Use this for initialization
	void Start () {
		f = 0;
		GameObject btnObj1 = GameObject.Find ("Canvas/zanting");
		Button btn1 = (Button)btnObj1.GetComponent<Button> ();
		btn1.onClick.AddListener (onClick);
	}

	// Update is called once per frame
	void Update () {
		if (f == 0)
			Time.timeScale = 1;
		else
			Time.timeScale = 0;
	}
	void onClick(){
		if (f == 0)
			f = 1;
		else
			f = 0;
	}


}
