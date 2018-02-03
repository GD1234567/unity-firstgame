using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject btnObj = GameObject.Find ("Canvas/bb");
		Button btn = (Button)btnObj.GetComponent<Button> ();
		btn.onClick.AddListener (onClick);
		GameObject btnObj2 = GameObject.Find ("Canvas/Main");
		Button btn2 = (Button)btnObj2.GetComponent<Button> ();
		btn2.onClick.AddListener (onClicka);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void onClick(){
			Application.Quit ();
	}
	void onClicka(){
		SceneManager.LoadScene ("2");
	}
}
