using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhadan : MonoBehaviour {
	public GameObject zha;
	public GameObject zj;
	public int gg = 0;
	public float xx = 0;
	public float yy = 0;
	public float zz = 0;
	void Start () {
	}
	void Update () {
		if (gg > 0) {
			gg = gg - 1;
			if (gg == 1)
				fzt ();
		}
		if (Input.GetKeyDown (KeyCode.J))
		if (GameObject.FindGameObjectWithTag ("ZDD") == null){
			gg = 110;
			fzd ();
	}
	}
	void fzd(){
		GameObject zdd = GameObject.Instantiate (zha);
		zdd.transform.position=new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);
		xx = zdd.transform.position.x;
		yy = zdd.transform.position.y;
		zz = zdd.transform.position.z;
		Destroy (zdd,2.5f);
	}
	void fzt(){
		GameObject zdda = GameObject.Instantiate (zj);
//		GameObject z = GameObject.Find ("ZHADAN");
		zdda.transform.position=new Vector3(xx,yy,zz);
	}
}
