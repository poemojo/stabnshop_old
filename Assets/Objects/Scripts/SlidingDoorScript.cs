using UnityEngine;
using System.Collections;

public class SlidingDoorScript : MonoBehaviour {
	public GameObject entranceDoorEast;
	public GameObject entranceDoorWest;
	public GameObject exitDoorEast;
	public GameObject exitDoorWest;
	public GameObject Player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.transform.position.z <= 30 && Player.transform.position.z > 0)
		{
			if (Player.transform.position.x <= 141 && Player.transform.position.x >= 111)
			{
				if (entranceDoorEast.transform.position.x >= 106) 
				{
					entranceDoorEast.transform.Translate (Vector3.left * Time.deltaTime);
					entranceDoorWest.transform.Translate (Vector3.right * Time.deltaTime);
				}
			}
			else
			{
				if (entranceDoorEast.transform.position.x < 119)
				{
					entranceDoorEast.transform.Translate (Vector3.right * Time.deltaTime);
					entranceDoorWest.transform.Translate (Vector3.left * Time.deltaTime);
				}
			}
			if (Player.transform.position.x <=32 && Player.transform.position.x >= 0)
			{
				if (exitDoorEast.transform.position.x >= -6)
				{
					exitDoorEast.transform.Translate (Vector3.left * Time.deltaTime);
					exitDoorWest.transform.Translate (Vector3.right * Time.deltaTime);
				}
			}
			else
			{
				if (exitDoorEast.transform.position.x < 8)
				{
					exitDoorEast.transform.Translate (Vector3.right * Time.deltaTime);
					exitDoorWest.transform.Translate (Vector3.left * Time.deltaTime);
				}
			}
		}
		else
		{
			if (entranceDoorEast.transform.position.x < 119)
			{
				entranceDoorEast.transform.Translate (Vector3.right * Time.deltaTime);
				entranceDoorWest.transform.Translate (Vector3.left * Time.deltaTime);
			}
			if (exitDoorEast.transform.position.x < 8)
			{
				exitDoorEast.transform.Translate (Vector3.right * Time.deltaTime);
				exitDoorWest.transform.Translate (Vector3.left * Time.deltaTime);
			}
		}
	}
}
