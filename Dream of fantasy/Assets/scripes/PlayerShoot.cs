using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerShoot : MonoBehaviour {
	public GameObject zidan1;
	public GameObject zidan2;
	public GameObject player;
	public int time = 0;
	//public float time1 = 0.5f;
	//public Rigidbody2D BB;
	void Start () {
	}
	void Update () {
		time = time + 1;
		if (Input.GetKeyDown(KeyCode.J)) {
			firea ();
		}
		if (Input.GetKeyDown(KeyCode.K)) {
			Onfireb ();
		}
}
	public void firea(){
		GameObject zidan = GameObject.Instantiate (zidan1);
		zidan.transform.position=new Vector3(player.transform.position.x+0.35f,player.transform.position.y+0.8f,player.transform.position.z);
		Rigidbody2D BB = zidan.AddComponent<Rigidbody2D> ();
		zidan.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,500,0));
		//for(int i=0;i<10000;i++){
		//if (Time.time>time+time1)
		//zidan.transform.position=new Vector3(zidan.transform.position.x,zidan.transform.position.y+0.8f,zidan.transform.position.z);
		//time = Time.time;
		//if (i == 9999)
		Destroy (zidan,0.3f);
		//}
	}
	public void Onfireb(){
		if (time > 25){
			GameObject zidan3 = GameObject.Instantiate (zidan2);
			zidan3.transform.position=new Vector3(player.transform.position.x+0.35f,player.transform.position.y+0.8f,player.transform.position.z);
			//Rigidbody2D BB = zidan3.AddComponent<Rigidbody2D> ();
			zidan3.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,250,0));
			time = 0;
			//for(int i=0;i<10000;i++){
			//if (Time.time>time+time1)
			//zidan.transform.position=new Vector3(zidan.transform.position.x,zidan.transform.position.y+1.8f,zidan.transform.position.z);
			//time = Time.time;
			//if (i == 9999)
			Destroy (zidan3,0.5f);
			//}
		}
	}

}
