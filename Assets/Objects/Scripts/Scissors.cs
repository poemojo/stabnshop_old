using UnityEngine;
using System.Collections;

public class Scissors : MonoBehaviour {
	public string scissorWords;
	bool displayText = false;
	public bool yesButtonClick = false;
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
				if (yesButtonClick == true && noButtonClick == false) {
					Destroy(gameObject);
				}
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
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height-200), scissorWords + " Should you take them?");
			if (GUI.Button (new Rect (20,40,220,20), "Neato burrito, I love pointy objects!")){
				yesButtonClick = true;
				executedTime = Time.time;
			}
			if (GUI.Button (new Rect (20,80,200,20), "I'll leave 'em be.")){
				noButtonClick = true;
				executedTime = Time.time;
			}
		}
		if (yesButtonClick) {
			displayText = false;
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height-200), "Stealing is for chumps.");
			if (Inventory.inventoryArray.Contains("scissors") == false) {
				Inventory.inventoryArray.Insert(0, "scissors");
			}
		}
		if (noButtonClick) {
			displayText = false;
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height-200), "A wise idea!");
			
		}
	}
	
}