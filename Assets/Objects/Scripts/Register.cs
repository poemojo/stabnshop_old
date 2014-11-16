using UnityEngine;
using System.Collections;

public class Register : MonoBehaviour {
	public string registerWords;
	bool displayText = false;
	bool yesButtonClick = false;
	bool noButtonClick = false;
	private float currentTime = 0.0f, executedTime = 0.0f, timeToWait = 2.0f;
	int clickCount = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentTime = Time.time;
		
		if(executedTime != 0.0f)
		{
			if(currentTime - executedTime > timeToWait)
			{
				//if (yesButtonClick == true && noButtonClick == false) {
					//Destroy(gameObject);
				//}
				executedTime = 0.0f;
				yesButtonClick = false;
				noButtonClick = false;
			
			}
		}
	}
	
	void OnMouseDown() {
		displayText = true;
		clickCount++;;
	}
	
	void OnMouseUp() {
		if (clickCount % 2 == 0) {
			displayText = false;
		}
	}

	void OnGUI() {
		if (displayText) {
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height-200), registerWords + " Should you take it?");
			if (GUI.Button (new Rect (20,40,220,20), "Yoink!")){
				yesButtonClick = true;
				executedTime = Time.time;
			}
			if (GUI.Button (new Rect (20,80,200,20), "Stealing is for squares.")){
				noButtonClick = true;
				executedTime = Time.time;
			}
		}
		if (yesButtonClick) {
			displayText = false;
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height-200), "You pocket the wad of cash (ya big jerk).");

		}
		if (noButtonClick) {
			displayText = false;
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height-200), "Right you are, my fine fellow!");
			
		}
	}
	
}
