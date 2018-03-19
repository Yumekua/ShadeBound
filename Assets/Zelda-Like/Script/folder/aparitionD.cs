using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparitionD : MonoBehaviour {

	public GameObject ColliderDetec;
    public GameObject Collider;
	Collider2D Collider_m; 
	// Use this for initialization
	void Start () {
       
        Collider_m = Collider.GetComponent<Collider2D> ();
        Collider_m.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {

    }

	private void OnTriggerEnter2D(Collider2D ColliderDetec)
    {
       
        Collider_m.enabled = false;

    }

	private void OnTriggerStay2D(Collider2D ColliderDetec)
    {

        
        Collider_m.enabled = false;
    }

	private void OnTriggerExit2D(Collider2D ColliderDetec)
    {

        
        Collider_m.enabled = true;

    }
}

