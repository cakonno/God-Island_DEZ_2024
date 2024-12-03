using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    //Header é o cabeçalho para separar as variáveis

    [Header("Components")]
    public GameObject dialogueObj; //é a janelinha onde aparece o diálogo
    public Image profileSprite; // referenciar o falante 
    public Text speechText; //texto de fala
    public Text actorName; // nome do falante

    //variáveis de controle
    private bool isShowing;
    private int index;
    private string[] sentences;

    [Header("Settings")]
    public float typingSpeed;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    //IEnumarator serve pra criar um método baseado no tempo
    IEnumerator TypeSentence()
    {
        //foreach serve para mostrar na caixa de diálogo letra por letra da fala do personagem

        foreach (char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    //para pular para próxima frase/fala
    public void NestSentence()
    {

    }

    //para chamar a fala do npc
    public void Speech(string[] txt)
    {
        if (!isShowing) //mostra a caixa de diálogo
        {
            dialogueObj.SetActive(true);
            sentences = txt;
            StartCoroutine(TypeSentence());
            isShowing = true;

        }
    }
}
