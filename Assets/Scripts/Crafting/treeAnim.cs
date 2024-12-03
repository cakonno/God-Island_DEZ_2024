using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeAnim : MonoBehaviour
{
    [SerializeField] private float treeHealth;
    [SerializeField] private Animator anim;


    public void OnHit()
    {
        treeHealth -- ;

        anim.SetTrigger("OnHit");

        if(treeHealth <= 0)
        {
            //aparece o toco (animacao cutted) - dropa madeira
            anim.SetTrigger("cut");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Axe"))
        {
            Debug.Log("colidiu");            
            OnHit();
        }
    }
}
