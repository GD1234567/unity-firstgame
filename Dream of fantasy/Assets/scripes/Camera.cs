using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Camera : MonoBehaviour {
	public GameObject ta;
	public float smoothing = 5f;
	Vector3 offset;
	void Start()
	{  ta = GameObject.Find ("Camera");
		offset = ta.transform.position - transform.position;
	}
	void FixedUpdate()
	{
		Vector3 camPos = ta.transform.position + offset;
		ta.transform.position = Vector3.Lerp(transform.position, camPos, smoothing * Time.deltaTime);
	}

}