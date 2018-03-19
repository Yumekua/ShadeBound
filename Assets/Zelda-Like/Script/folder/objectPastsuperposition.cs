using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectPastsuperposition : MonoBehaviour
{

    Renderer myCollider;
    public GameObject rendererObject;
    Renderer myCollider2;
    public GameObject rendererObject2;
    public GameObject collidr;

    public bool pilierSyle;

    void Start()
    {
      
        myCollider = rendererObject.GetComponent<Renderer>();
        myCollider2 = rendererObject2.GetComponent<Renderer>();
    }

    private void OnTriggerEnter2D(Collider2D ColliderDetec)
    {


        if (ColliderDetec.gameObject.name == "Joueur" || ColliderDetec.gameObject.tag == "monster" )
        {
           
                myCollider.sortingOrder = -1;
                myCollider2.sortingOrder = 69;
               
        }

    }



private void OnTriggerExit2D(Collider2D ColliderDetec)
    {


        if (ColliderDetec.gameObject.name == "Joueur" || ColliderDetec.gameObject.tag == "monster")
        {             
            
                myCollider.sortingOrder = -3;
                myCollider2.sortingOrder = 67;
            

        }


    }
}
