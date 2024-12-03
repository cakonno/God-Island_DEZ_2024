using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //velocidade
    [SerializeField] private float speed;
    [SerializeField] private float runSpeed;

    //referente a física do jogo
    private Rigidbody2D rig;

    private float initialSpeed;
    private bool _isRunning;
    private bool _isRolling;
    private bool _isCutting;

    //referente à direção de movimento
    private Vector2 _direction;

    public bool isCutting
    {
        get { return _isCutting; }
        set { _isCutting = value; }
    }

    public bool isRolling
    {
        get { return _isRolling; }
        set { _isRolling = value; }
    }

    public bool isRunning
    {
        get { return _isRunning; }
        set { _isRunning = value; } 
    }

    public Vector2 direction
    {
        get { return _direction; }
        set { _direction = value; }
    }


    //VOID É UM MÉTODO NA C#/ MÉTODO É COMO UM COMPORTAMENTO    

    // VOID START É A CONFIGURAÇÃO PARA INÍCIO DE JOGO
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        initialSpeed = speed;
    }

    //É UM METODO QUE ATUALIZA A CADA FRAME/SÃO 60 FRAMES POR SEGUNDO
    // Update is called once per frame

    private void Update()
    {
        OnInput();
        OnRun();
        OnRolling();
        OnCutting();
    }

    void FixedUpdate()
    {
        OnMove();
    }

    #region Moviment

    void OnInput()
     {
       _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
     }

    void OnMove()
    {
        rig.MovePosition(rig.position + _direction * speed * Time.fixedDeltaTime);
    }

    void OnRun()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = runSpeed;
            _isRunning = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = initialSpeed;
            _isRunning = false;
        }
        
    }

    void OnRolling()
    {
        // Botões do Mouse -> 0 (esquerdo) e 1 (direito)

        if (Input.GetMouseButtonDown(1))
        {
            _isRolling = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            _isRolling = false;
        }
    }
        
    void OnCutting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isCutting = true;
            speed = 0f;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isCutting = false;
            speed = initialSpeed;
        }
    }

    #endregion
}
