using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trnasparence : MonoBehaviour {

	SpriteRenderer myCollider;

	void Start () {

		myCollider = GetComponent<SpriteRenderer>();
	}

	private void OnTriggerStay2D(Collider2D ColliderDetec)
	{


		if (ColliderDetec.gameObject.name == "Joueur") {

			myCollider.color = new Color32 (255, 255, 255, 130);
		}

	}

	private void OnTriggerExit2D(Collider2D ColliderDetec)
	{


		if (ColliderDetec.gameObject.name == "Joueur") {

			myCollider.color = new Color32 (255, 255, 255, 255);
		}


	}
}
