using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	
	void levels(){
		Application.LoadLevel("levels");
	}
	
	void exit(){
		Application.Quit();
	}
	
	void level1(){
		Application.LoadLevel("level1");
	}
	
	void level2(){
		Application.LoadLevel("level2");
	}
	
	void back(){
		Application.LoadLevel("mainMenu");
	}

	void Start(){
		
		Screen.showCursor = true;
	}
}
