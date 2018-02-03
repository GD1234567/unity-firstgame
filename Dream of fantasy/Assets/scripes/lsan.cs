using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lsan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Button btn2 = (Button)this.GetComponent<Button> ();
		btn2.onClick.AddListener (onClickb);
	}
	void onClickb(){
		GameObject zt = GameObject.Find ("Canvas/ls");
		zt.SetActive (false);
	}
}
