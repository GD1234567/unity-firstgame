using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class shexiangtou : MonoBehaviour {
	public GameObject taiji;
	public float ss = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.transform.position.y < 13.8)
			transform.Translate (new Vector3 (0, 1, 0) * 2 * Time.deltaTime);
		else {
			taiji.transform.Rotate (0, 0, -1);
			ss = ss + 1;
		}
		if (ss == 180)
			SceneManager.LoadScene ("3");
	}
}
