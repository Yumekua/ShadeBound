using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawMonster : MonoBehaviour {


	public GameObject enemy;

	private void OnTriggerEnter2D(Collider2D ColliderDetec)
	{
		

		if (ColliderDetec.gameObject.name == "Joueur") {

			enemy.transform.position = transform.position;
			Destroy (gameObject);
		}


	}
}
