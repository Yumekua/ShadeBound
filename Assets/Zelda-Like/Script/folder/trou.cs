using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trou : MonoBehaviour
{
    public GameObject arbre;
    public GameObject plante;
    public GameObject A;
    public GameObject graine;

    bool finish;

    private void OnTriggerStay2D(Collider2D ColliderDetec)
    {


        if (ColliderDetec.gameObject.name == "Joueur")
        {
            if (finish == false)
            {
                A.SetActive(true);
                if (graine.activeSelf)
                {

                    if (Input.GetButton("A") || Input.GetKey(KeyCode.D))
                    {
                        finish = true;
                        graine.SetActive(false);
                        plante.SetActive(true);
                        arbre.SetActive(true);

                    }
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D ColliderDetec)
    {
        A.SetActive(false);


    }
}
