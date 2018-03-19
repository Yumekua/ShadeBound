using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbreTombre : MonoBehaviour
{
	public GameObject dash;
	Collider2D myCollider;
	public GameObject Tag;
    public GameObject gameobject;
    public GameObject gameobject2;
	public GameObject gameobject3;
    bool finish;
    Animator anim;
    public GameObject first;

    void Start()
	{
        anim = first.GetComponent<Animator>();
        myCollider = gameobject.GetComponent<Collider2D>();
    }

	void Update()
	{
		
        if (finish == false)
        {
            if (!Tag.activeSelf)
            {
                if (Input.GetAxisRaw("TurnRight") < -0.5f || Input.GetKey(KeyCode.Space))
                {


                    myCollider.enabled = false;

                }
                else
                {
                    myCollider.enabled = true;


                }
            }
            else myCollider.enabled = true;
        }
		
	}

	private void OnTriggerStay2D(Collider2D ColliderDetec)
	{
		if (ColliderDetec.gameObject.name == "Joueur")

		{
            

            if (dash.activeSelf)
			{
                gameobject2.SetActive(true);
				gameobject3.SetActive(false);
                anim.SetBool("arbre", true);
                finish = true;
            }






		}
	}
}
