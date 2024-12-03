using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Dialogue : MonoBehaviour

{
    //1o criar um colisor

    public float dialogueRange; //tamanho do colisor
    public LayerMask playerLayer; //identificador da presen�a do player
                              // Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame

    //Usamos um fixedupdate no lugar de um update. O Fixed update � chamdo pelo sistema de f�sica da unity
    //ent�o ele n�o ele n�o � chamado a cada frame, ele � chamado a cada ocorr�ncia que envolva a f�sica;
    void FixedUpdate()
    {
        ShowDialogue();
    }

    void ShowDialogue()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, dialogueRange, playerLayer);

        if (hit != null)
        {
            Debug.Log ("player na �rea de colis�o");
        }
    }
        

    private void OnDrawGizmosSelected()
    {
       Gizmos.DrawWireSphere(transform.position, dialogueRange);
    }
}
// Eu sou um p�o de queijoalho :)doce pastel de queijo com caf� com leite cum toditomate X tudoazeiter e tempe