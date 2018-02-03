using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class pinmu : MonoBehaviour {
	public UnityEngine.UI.CanvasScaler
	referenceCanvas;
	// Use this for initialization
	void Start () {
		if (referenceCanvas) {
			transform.localScale = referenceCanvas.transform.localScale * 100f;
		}
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (Application.platform==RuntimePlatform.OSXEditor||Application.platform==RuntimePlatform.WindowsEditor){
			{
				if (referenceCanvas) {
					transform.localScale = referenceCanvas.transform.localScale * 100f;
				}
			}
		}
	}
}
