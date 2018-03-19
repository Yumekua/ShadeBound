using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbrePomme : MonoBehaviour {

    public GameObject ColliderDetec;
    public GameObject Pomme;
    bool plant;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D ColliderDetec)
    {
		if (Input.GetButtonDown("A") || Input.GetKeyDown(KeyCode.D))
        {
            if (plant == false)
            {
                Debug.Log("test");
                Pomme.transform.localPosition = new Vector2(2.5f, 1.29f);
                plant = true;
            }
     
        }


    }
}
