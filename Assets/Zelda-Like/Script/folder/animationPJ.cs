using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationPJ : MonoBehaviour {

   
    Animator anim;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Vertical") < -0.5 || Input.GetKey(KeyCode.DownArrow))
        {// bas
            anim.SetInteger("Idle", 0);
        }

        else if (Input.GetAxisRaw("Horizontal") < -0.5 || Input.GetKey(KeyCode.LeftArrow))
        { // gauche

            anim.SetInteger("Idle", 1);
        }

        else if (Input.GetAxisRaw("Horizontal") > 0.5 || Input.GetKey(KeyCode.RightArrow))
        { // droite

            anim.SetInteger("Idle", 3);
        }

        else if (Input.GetAxisRaw("Vertical") > 0.5 || Input.GetKey(KeyCode.UpArrow))
        {   // haut	

            anim.SetInteger("Idle", 2);

        }
       
       
    }
}
