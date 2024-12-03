using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Dialogue : MonoBehaviour

{
    //1o criar um colisor

    public float dialogueRange; //tamanho do colisor
    public LayerMask playerLayer; //identificador da presença do player
                              // Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame

    //Usamos um fixedupdate no lugar de um update. O Fixed update é chamdo pelo sistema de física da unity
    //então ele não ele não é chamado a cada frame, ele é chamado a cada ocorrência que envolva a física;
    void FixedUpdate()
    {
        ShowDialogue();
    }

    void ShowDialogue()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, dialogueRange, playerLayer);

        if (hit != null)
        {
            Debug.Log ("player na área de colisão");
        }
    }
        

    private void OnDrawGizmosSelected()
    {
       Gizmos.DrawWireSphere(transform.position, dialogueRange);
    }
}
// Eu sou um pão de queijoalho :)doce pastel de queijo com café com leite cum toditomate X tudoazeiter e tempe