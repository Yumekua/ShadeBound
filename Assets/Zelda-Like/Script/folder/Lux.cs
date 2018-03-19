using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lux : MonoBehaviour {

    //luxBarre
    public GameObject spritecolor;
    private bool Waits;
    public GameObject Light;
    public GameObject player;
    public GameObject playersprite;
    public bool reActive;

    //Catalyste
    byte CatalysteBarre;
    public GameObject indic;
    bool modeCatalyste;
	public GameObject Tag;
    Renderer mysprite;

    //gestionControle
    public bool stop;
	public bool degat;


    void Start()
    {
        mysprite = playersprite.GetComponent<Renderer>();


    }


    void Update()
    {
		if (degat == true) {
			degat = false;
			if (transform.localScale.x >= 3) {
				transform.localScale = new Vector3 (transform.localScale.x - 4, 0.3f, 0.5f);


			} else if (transform.localScale.x < 3){
				transform.localScale = new Vector3 (0, 0.3f, 0.5f);
			}
			if (Waits == true) {
				SceneManager.LoadScene ("Level");
			}

		}
            

            if (transform.localScale.x >= 2)
            {
                spritecolor.GetComponent<SpriteRenderer>().color = new Color32(147, 148, 255, 255);

            }

            if (transform.localScale.x < 2)
            {
                spritecolor.GetComponent<SpriteRenderer>().color = new Color32(219, 61, 89, 255);


            }

			if (Waits == true)
			{
			spritecolor.GetComponent<SpriteRenderer>().color = new Color32(147, 148, 157, 255);


			}


		if (Waits == true){
			if (transform.localScale.x >= 6)
			{
				player.GetComponent<Deplacement>().movespeeds = 45;
				player.GetComponent<Deplacement>().stop = false;
				Tag.SetActive(false);
                player.tag = "player";
                stop = false;
				Waits = false;
			}else{

				transform.localScale = new Vector3(transform.localScale.x + 0.01f, 0.3f, 0.5f);
			}
		}

		if (transform.localScale.x <= 0.1f)
		{
			Tag.SetActive(true);
            player.tag = "playerF";
            Waits = true;
			player.GetComponent<Deplacement>().movespeeds = 30;
			Light.SetActive(false);
			StartCoroutine("Wait");

		}

      
                #region LuxBarre


					if (Input.GetAxisRaw ("TurnRight") < -0.5f || Input.GetKey(KeyCode.Space))
                    {
				
						
							
								if (Waits == false)
								if (reActive == false)
								{
									Light.SetActive(true);
                                     mysprite.sortingOrder = 68;

									if (transform.localScale.x > 0)
									{

										transform.localScale = new Vector3(transform.localScale.x - 0.005f, 0.3f, 0.5f);

									}


								}


								if (transform.localScale.x <= 0)
								{
									Waits = true;
                                    mysprite.sortingOrder = -2;
									player.GetComponent<Deplacement>().movespeeds = 30;
									Light.SetActive(false);
									StartCoroutine("Wait");

								}


							
						 
                    }
                    else
                    {
			                mysprite.sortingOrder = -2;

							if (Waits == false)
							{

								Light.SetActive(false);

								if (transform.localScale.x < 6)
								{
									transform.localScale = new Vector3(transform.localScale.x + 0.007f, 0.3f, 0.5f);

								}
							}
						
                    }

           

                    if (transform.localScale.x > 6)
                    {
                        indic.SetActive(true);

                    }
                    else
                    {
                       

                        indic.SetActive(false);

                    }
            #endregion
        
			 

    }



    IEnumerator Wait()
    {

        player.GetComponent<Deplacement>().stop = true;
        player.GetComponent<Deplacement>().movespeeds = 30;
		transform.localScale = new Vector3 (transform.localScale.x + 0.007f, 0.3f, 0.5f);
        yield return new WaitForSeconds(0.1f);
       



    }
}
