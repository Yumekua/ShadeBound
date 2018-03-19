using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topvisible : MonoBehaviour {

    public GameObject ColliderDetec;
    public GameObject Collider;
	public GameObject barreLight;
   
    // Use this for initialization
    void Start()
    {

        Collider.SetActive(true);       
    }

    // Update is called once per frame
    void Update()
    {
		
	
    }

    private void OnTriggerEnter2D(Collider2D ColliderDetec)
    {
		if (barreLight.GetComponent<Lux> ().stop == false) {
			Collider.SetActive (false);
		} else {

			Collider.SetActive (true);
		}

    }

    private void OnTriggerStay2D(Collider2D ColliderDetec)
    {

		if (barreLight.GetComponent<Lux> ().stop == false) {
			Collider.SetActive (false);
		} else {

			Collider.SetActive (true);
		}

    }

    private void OnTriggerExit2D(Collider2D ColliderDetec)
    {


        Collider.SetActive(true);

    }
}
