using UnityEngine;
using System.Collections;

public class TextBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void onGUI () {
		Rect rect1 = new Rect(10, Screen.height-30, Screen.width-60, 30);
		Rect rect2 = new Rect(Screen.width-60, Screen.height-30, 60, 30); 
		GUI.TextField (rect1, "", 30);
		GUI.Button (rect2, "post");
	}
}
