using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerChange : MonoBehaviour {

	Renderer myCollider;
	public GameObject rendererObject;

	void Start () {

		myCollider = rendererObject.GetComponent<Renderer>();
	}

	private void OnTriggerEnter2D(Collider2D ColliderDetec)
	{

       
        if (ColliderDetec.gameObject.name == "Joueur")
        {

            myCollider.sortingOrder = 68;
        }


    }

	private void OnTriggerExit2D(Collider2D ColliderDetec)
	{


		if (ColliderDetec.gameObject.name == "Joueur") {
			
			myCollider.sortingOrder = 67;
		}


	}
}

