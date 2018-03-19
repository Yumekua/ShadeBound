using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActive : MonoBehaviour {

	public GameObject Tag;
	public GameObject Trigger;
	public GameObject barreLight;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (!Tag.activeSelf){
			if (Input.GetAxisRaw ("TurnRight") < -0.5f || Input.GetKey(KeyCode.Space)) {
				Trigger.SetActive (true);

			} 
			else 
			{
					Trigger.SetActive (false);

				
			}

		}else Trigger.SetActive (false);
	}
}
