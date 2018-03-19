using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollider : MonoBehaviour {

	public GameObject monster1;
	public GameObject luxbarre;
	public bool charge;


	private void OnTriggerEnter2D(Collider2D ColliderDetec)
	{
		if (ColliderDetec.gameObject.name == "AoE") {

			monster1.GetComponent<Monster> ().lifepoint--;
			Debug.Log (monster1.GetComponent<Monster> ().lifepoint);
			monster1.GetComponent<Monster> ().touch = true;

		}

		if (ColliderDetec.gameObject.tag == "obstacle") {
			monster1.GetComponent<Monster> ().touch = false;
			monster1.GetComponent<Monster> ().mur = true;
		}

		if (ColliderDetec.gameObject.tag == "death") {

			Destroy (monster1);
		}

		if (ColliderDetec.gameObject.tag == "monster") {

			monster1.GetComponent<Monster> ().touch3 = true;
			monster1.GetComponent<Monster> ().dir2 = transform.position - ColliderDetec.gameObject.transform.position;
		}

		if (ColliderDetec.gameObject.name == "Joueur" && charge == false) {
			    
				monster1.GetComponent<Monster> ().charge = true;
				luxbarre.GetComponent<Lux> ().degat = true;
				charge = true;
				StartCoroutine("FinsihAtk");

			}


	}

	private void OnTriggerStay2D(Collider2D ColliderDetec)
	{
		
		if (ColliderDetec.gameObject.tag == "obstacle") {

			monster1.GetComponent<Monster> ().mur = true;
		} else {

			monster1.GetComponent<Monster> ().mur = false;
		}
	}

	IEnumerator FinsihAtk()
	{
		yield return new WaitForSeconds(0.1f); //0.5F
		charge = false;
		monster1.GetComponent<Monster> ().charge = false;
	}
}
