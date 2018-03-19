using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pomme : MonoBehaviour {

    public GameObject ColliderDetec;
    public GameObject Pomme;
    public GameObject pommeObject;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    private void OnTriggerStay2D(Collider2D ColliderDetec)
    {
		if (Input.GetButton("A") || Input.GetKeyDown(KeyCode.D))
        {
            Pomme.transform.localPosition = new Vector2(2.5f, 1.29f);
         
            Destroy(pommeObject);
        }
           

    }
}
