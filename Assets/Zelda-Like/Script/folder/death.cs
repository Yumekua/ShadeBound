using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class death : MonoBehaviour {

	public GameObject ColliderDetec;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
		
	private void OnTriggerStay2D(Collider2D ColliderDetec)

    {
		if (ColliderDetec.gameObject.name == "Joueur") {
			Debug.Log("dead");
			SceneManager.LoadScene ("Prefabs Final");
		}
	}
	
}
