using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PowerTools;


public class Deplacement : MonoBehaviour
{

    Rigidbody2D myrigidbody2D;
    public float movespeed;
    public GameObject Light;
    public byte direction = 0;  //bas = 0 gauche = 1 haut = 2 droite = 3 / b-g = 4 b-d = 5 h-g = 6 h-d = 7
    public float movespeeds;
    public bool move;
    bool coroutine;
    bool dash;
    public bool stop;
    public GameObject aoe;
    public GameObject barreLight;
    public GameObject left;
    public GameObject down;
    public GameObject right;
    public GameObject dashobject;


    // Use this for initialization
    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {  

        movespeed = movespeeds + 20;

        // deplacement
        

            if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
                myrigidbody2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, myrigidbody2D.velocity.y);     

            if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
                myrigidbody2D.velocity = new Vector2(myrigidbody2D.velocity.x, Input.GetAxisRaw("Vertical") * movespeed);

            if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
                myrigidbody2D.velocity = new Vector2(0f, myrigidbody2D.velocity.y);

            if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
                myrigidbody2D.velocity = new Vector2(myrigidbody2D.velocity.x, 0f);

			if (Input.GetKey(KeyCode.UpArrow))
				myrigidbody2D.velocity = new Vector2(myrigidbody2D.velocity.x, 1 * movespeed);	
				
			if (Input.GetKey(KeyCode.DownArrow))
				myrigidbody2D.velocity = new Vector2(myrigidbody2D.velocity.x, -1 * movespeed);	

			if (Input.GetKey(KeyCode.LeftArrow))
				myrigidbody2D.velocity = new Vector2(-1 * movespeed, myrigidbody2D.velocity.y); 

			if (Input.GetKey(KeyCode.RightArrow))
				myrigidbody2D.velocity = new Vector2(1 * movespeed, myrigidbody2D.velocity.y);


        //direction

        if (Input.GetAxisRaw("Vertical") < -0.5 || Input.GetKey(KeyCode.DownArrow))
        {// bas
            direction = 0;
            down.SetActive(true);
            right.SetActive(false);
            left.SetActive(false);
        }

        else if (Input.GetAxisRaw("Horizontal") < -0.5 || Input.GetKey(KeyCode.LeftArrow))
        { // gauche
            down.SetActive(false);
            right.SetActive(false);
            left.SetActive(true);
            direction = 1;

        }

        else if (Input.GetAxisRaw("Horizontal") > 0.5 || Input.GetKey(KeyCode.RightArrow))
        { // droite
            down.SetActive(false);
            right.SetActive(true);
            left.SetActive(false);
            direction = 3;
        }

        else if (Input.GetAxisRaw("Vertical") > 0.5 || Input.GetKey(KeyCode.UpArrow))
        {   // haut	
            down.SetActive(false);
            right.SetActive(false);
            left.SetActive(false);
            direction = 2;
        }
        

      

        

		if (Input.GetButton("X") || Input.GetKey(KeyCode.Q))
        {
            if (coroutine == false)
            {
                dashobject.SetActive(true);
                StartCoroutine("Dash");
                coroutine = true;
            }

            if (dash == false)
            {
                if (direction == 0)
                    myrigidbody2D.velocity = new Vector2(0, -200);
                else if (direction == 1)
                    myrigidbody2D.velocity = new Vector2(-200, 0);
                else if (direction == 2)
                    myrigidbody2D.velocity = new Vector2(0, 200);
                else if (direction == 3)
                    myrigidbody2D.velocity = new Vector2(200, 0);
            }

        }
		else
		{
			if (stop == false) {
				movespeeds = 45;
			} else {
				movespeeds = 30;

			}
			movespeed = movespeeds + 20;
            coroutine = false;
            dash = false;
        }




        if (coroutine == false)
        {

			if (Input.GetButtonDown("B") || Input.GetKeyDown(KeyCode.Z))
            {


                if (direction == 0)
                    aoe.transform.localRotation = Quaternion.Euler(0, 0, 0);


                else if (direction == 1)
                    aoe.transform.localRotation = Quaternion.Euler(0, 0, -90);


                else if (direction == 2)
                    aoe.transform.localRotation = Quaternion.Euler(0, 0, 180);

                else if (direction == 3)
                    aoe.transform.localRotation = Quaternion.Euler(0, 0, 90);


                aoe.SetActive(true);
                Light.SetActive(false);
                barreLight.GetComponent<Lux>().reActive = true;
                StartCoroutine("FinsihAtk");

            }
            else
            {
				if ( barreLight.GetComponent<Lux>().reActive == false)
                aoe.SetActive(false);

            }

        }
       
    }

    IEnumerator Dash()
    {
        yield return new WaitForSeconds(0.15f);
        dash = true;
        dashobject.SetActive(false);
    }


    IEnumerator FinsihAtk()
    {
        yield return new WaitForSeconds(0.1f); //0.5F
        barreLight.GetComponent<Lux>().reActive = false;

    }
    

}

