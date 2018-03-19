using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graine : MonoBehaviour
{
  
    public GameObject first;
    public GameObject A;
    public GameObject graine;

    private void OnTriggerStay2D(Collider2D ColliderDetec)
    {

        if (ColliderDetec.gameObject.name == "Joueur")
        {
            A.SetActive(true);

            if (Input.GetButton("A") || Input.GetKey(KeyCode.D))
            {
                graine.SetActive(true);
                Destroy(first);

            }
        }
    }

    private void OnTriggerExit2D(Collider2D ColliderDetec)
    {
        A.SetActive(false);
        

    }
}
