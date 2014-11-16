using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Inventory : MonoBehaviour
{
	public static List<string> inventoryArray = new List<string>();
	bool print1 = false;

	void Start () {
	}
	
	void Update ()
	{
		if (inventoryArray.Count != 0) {
			//print (inventoryArray [0]);
			print1 = true;
		}
	}

	void OnGUI() {
		if (print1) {
			if (GUI.Button (new Rect (625,15,220,20), "Inventory")) {
				for (int i = 0; i < inventoryArray.Count; i++) {
					print (inventoryArray[i] + " ");
				}
			}
		}
	}
}