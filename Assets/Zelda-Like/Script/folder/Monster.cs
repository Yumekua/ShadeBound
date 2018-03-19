using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Monster : MonoBehaviour {

	public GameObject Tag;
	AIPath scan;
	Collider2D myCollider;
	int moveSpeed = 5;
	public GameObject Target;
	public bool touch;
	public bool mur;
	bool touch2;
	public bool touch3;
	public Vector2 dir2;
	public bool charge;
	public int lifepoint = 1;

	// Use this for initialization
	void Start () {

		scan = GetComponent<AIPath>();
		myCollider = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if (!Tag.activeSelf) {
			if (Input.GetAxisRaw ("TurnRight") < -0.5f || Input.GetKey(KeyCode.Space)) {


				myCollider.enabled = true;

			} else {
				myCollider.enabled = false;
					

			}
		}else myCollider.enabled = false;

		if ((touch == true || charge == true) && mur == false) {
			
			scan.enabled = false;
			Vector2 dir = transform.position - Target.transform.position;
			transform.Translate(dir * moveSpeed * 2 * Time.deltaTime);
			StartCoroutine("FinsihAtk");
			StartCoroutine("Renvoi");
		}

		if (touch3 == true && mur == false) {
			scan.enabled = false;
			transform.Translate(dir2 * moveSpeed * Time.deltaTime);
			StartCoroutine("Touch");
		}

		if (lifepoint <= 0) {
			Destroy (gameObject);
		}

	}
		

	private void OnTriggerStay2D(Collider2D ColliderDetec)
	{


			if (ColliderDetec.gameObject.name == "Joueur") {
			
				touch2 = true;


			} else {

		
				touch2 = false;
		
			}

			if (ColliderDetec.gameObject.name == "Joueur") {




			} 

			if (ColliderDetec.gameObject.tag == "obstacle") {


			} else {
			if ( touch2 == true && mur == false) {
					scan.enabled = false;
					Vector2 dir = transform.position - Target.transform.position;
					transform.Translate (dir * moveSpeed * Time.deltaTime);
				}
			}
			
		


	}

	private void OnTriggerExit2D(Collider2D ColliderDetec)
	{

			if (ColliderDetec.gameObject.name == "Joueur") {

				scan.enabled = true;
			}
	}

	IEnumerator FinsihAtk()
	{
		yield return new WaitForSeconds(0.5f); //0.5F
		scan.enabled = true;

	}

	IEnumerator Renvoi()
	{
		yield return new WaitForSeconds(0.1f); 
		touch = false;

	}
		
	IEnumerator Touch()
	{
		yield return new WaitForSeconds(0.1f);
		scan.enabled = true;
		touch3 = false;

	}


}
