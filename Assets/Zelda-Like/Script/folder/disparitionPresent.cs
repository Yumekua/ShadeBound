using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparitionPresent : MonoBehaviour
{
    public GameObject spritePresent;


    private void OnTriggerStay2D(Collider2D ColliderDetec)
    {
        if (ColliderDetec.gameObject.tag == "player" )
        {
            if (Input.GetAxisRaw("TurnRight") < -0.5f || Input.GetKey(KeyCode.Space))
            {
                spritePresent.SetActive(true);
              
            }
            else
            {
                spritePresent.SetActive(false);
               
            }
        }
        else
        {
            spritePresent.SetActive(false);

        }
  

    }

    private void OnTriggerExit2D(Collider2D ColliderDetec)
    {

        if (ColliderDetec.gameObject.tag == "player") {
            spritePresent.SetActive(false);

        }
          



    }
}
