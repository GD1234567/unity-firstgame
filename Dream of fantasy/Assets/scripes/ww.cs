using UnityEngine;  
using System.Collections;  
using UnityEngine.SceneManagement;
public class ww : MonoBehaviour  
{  
	private float letterPause = 0.164f;  
	public AudioClip cl;  
	//private AudioSource source;   
	private string word;  
	public int bb; 
	//public int pp = 0; 
	private string text = "人类对动物的迫害，\n令动物们痛苦不堪，\n同时自然失去了平衡。\n你作为人类中觉悟最高,智商最高的人，\n由你来完成拯救动物这光明的使命！\nCome on，Human！\nTry your best to finish this mission!                       ";  
	GUIStyle ff = new GUIStyle ();
	void Start()  
	{  
		//source = GetComponent<AudioSource>();  
		word = text;  
		text = "";  
		ff.normal.textColor = new Color(255,255,255);
		//ff.normal.textColor = new Color(168,58,92);
		ff.fontSize = 33;
		StartCoroutine(TypeText());  
		AudioSource.PlayClipAtPoint (cl,transform.position);
	}  

	void OnGUI()  
	{  
		//GUI.Label(new Rect(200, 65, 200, 200), "Warning!",ff);  
		GUI.Label(new Rect(Screen.width/3.3f, Screen.height/4, Screen.width, Screen.height), text,ff);  
	}  
	private IEnumerator TypeText()  
	{  
		foreach (char letter in word.ToCharArray())  
		{  
			text += letter; 
			bb = bb + 1;
			//if(clip )  
			//{  
				//source.PlayOneShot(clip);  

			//}  
			if (bb == 120)
				SceneManager.LoadScene ("2");
			yield return new WaitForSeconds(letterPause);  
		}  
	}  
} 