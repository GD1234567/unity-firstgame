using UnityEngine;
using System.Collections;

[AddComponentMenu("MyGame/Player")]
public class playermove : MonoBehaviour {
	//float movev=0;
	//float moveh=0;
    public float m_speed = 1;
	void Update () {   
		float movev=0;   
		float moveh=0;  
		if ( Input.GetKey( KeyCode.S) )  
		{  
			movev -= m_speed*Time.deltaTime;  
		}   
		if ( Input.GetKey( KeyCode.W ) )  
		{  
			movev += m_speed * Time.deltaTime;  
		}    
		if ( Input.GetKey( KeyCode.D ) )  
		{  
			moveh += m_speed * Time.deltaTime;  
		}   
		if ( Input.GetKey( KeyCode.A ) )  
		{  
			moveh -= m_speed * Time.deltaTime;  
		}   
		this.transform.Translate( new Vector3( moveh, movev,0 ) ); 
}
}