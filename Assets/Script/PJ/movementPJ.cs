using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class movementPJ : MonoBehaviour
{
    [Header("-- Basic param --")]
    [SerializeField] private Rigidbody2D m_rigidbody;
    [SerializeField] private Animator m_animator;
    [SerializeField] private float limiteInput_movX;
    [SerializeField] private float velocidadHorizontal = 4f;
    [SerializeField] private float potenciaSalto = 9f;
    //[SerializeField] private float caida = 10f;
    //[SerializeField]private float gravedad = -9.8f;
    private bool vivo = true, move = true;

    private Vector3 movimientoHorizontal;

    [SerializeField] public float acceleration;
    [SerializeField] public float decceleration;
    private float velPower=1;
    [SerializeField] private grounded m_grounded;
    [SerializeField] private changeMirada changeMirada;

    [Header("-- Run --")]
    [SerializeField]private float factorRun;
    private bool isRun = false;


    private NewControls m_ControlPJ;
    private void Awake()
    {
        m_ControlPJ = new NewControls();
        m_ControlPJ.PLAYER.Enable();

        m_ControlPJ.PLAYER.Jump.performed += jump;
        m_ControlPJ.PLAYER.Jump.canceled += detenerJump;

        m_ControlPJ.PLAYER.Movement_X.performed += getInput_Horizontal;
        m_ControlPJ.PLAYER.Movement_X.canceled += setZerotInput_Horizontal;

        m_ControlPJ.PLAYER.Run.started += startRun;
        m_ControlPJ.PLAYER.Run.canceled += cancelRun;
    }
    private void startRun(InputAction.CallbackContext ctx)
    {
        isRun = true;
    }
    private void cancelRun(InputAction.CallbackContext ctx)
    {
        isRun = false;
    }
    private void OnEnable(){m_ControlPJ.PLAYER.Enable();}
    private void OnDisable(){m_ControlPJ.PLAYER.Disable();}
    void Update()
    {
        if (move)
        {
            m_isGrounded = m_grounded.isGrounded();
            //if(!m_isGrounded) isRun = false;
            m_animator.SetBool("ground", m_isGrounded);
            if (vivo)
            {
                //getInput_Horizontal();
                changeMirada.miradaPj(valorInput_Horizontal);
                /*
                if (m_grounded.isGrounded())
                {
                     if (Input.GetButtonDown("Jump"))
                    {
                        jump();
                    }
                }*/


                //if (m_rigidbody.velocity.y > 0 && Input.GetButtonUp("Jump"))
                //{
                //    detenerJump();
                //}
            }
            m_animator.SetFloat("velocity_Y", m_rigidbody.velocity.y);
        }

    }
    
    private void FixedUpdate()
    {
        if (move && vivo)
        {
            float currentFactorRun = 1;
            if (isRun) currentFactorRun = factorRun;
            float factorSalto = 0.7f;
            if (m_isGrounded) factorSalto = 1;
            float targetSpeed = valorInput_Horizontal * velocidadHorizontal * currentFactorRun * factorSalto;

            //m_animator.SetFloat("Velocity_X", Mathf.Abs(valorInput));

            float speedDif = targetSpeed - m_rigidbody.velocity.x;
            float accelRate = (Mathf.Abs(targetSpeed) > 0.01f) ? acceleration : decceleration;
            float movement = Mathf.Pow(Mathf.Abs(speedDif)* accelRate, velPower)* Mathf.Sign(speedDif);


            m_rigidbody.AddForce(movement * Vector2.right );


        }
    }
    //changeMirada.miradaPj
    private float valorInput_Horizontal;
    private void getInput_Horizontal(InputAction.CallbackContext ctx)
    {
        //print("ctx.interaction-- " + ctx.interaction);
        
        if (ctx.performed)
        {
            float currentValor = ctx.ReadValue<Vector2>().x;
            if(Mathf.Abs(currentValor) > limiteInput_movX)
                valorInput_Horizontal = currentValor;
            else valorInput_Horizontal = 0;
        }
        //if (ctx.canceled || !ctx.performed)
       // {
        //    valorInput_Horizontal = 0;
        //}
        m_animator.SetFloat("Velocity_X", Mathf.Abs(valorInput_Horizontal));
        


        //movimientoHorizontal.x = 0;
        //movimientoHorizontal.x = Input.GetAxis("Horizontal");
        //m_animator.SetFloat("Velocity_X", Mathf.Abs(movimientoHorizontal.x));
        //return movimientoHorizontal.x;
    }
    private void setZerotInput_Horizontal(InputAction.CallbackContext ctx)
    {
        valorInput_Horizontal = 0;
        m_animator.SetFloat("Velocity_X", 0);
    }
    private bool m_isGrounded = false;
    private void jump( InputAction.CallbackContext ctx )
    {
        //print("jump!"+ctx);
        //print("------"+ctx.phase.ToString());
       // print("------" + ctx.phase.ToString());
       // print("------" + ctx.phase.ToString());
        if (move && vivo)
        {
            if (m_isGrounded)
            {
                m_animator.SetTrigger("startJump");
               // if (ctx.performed)
                    m_rigidbody.AddForce(Vector2.up * potenciaSalto, ForceMode2D.Impulse);
                //if (ctx.canceled || !ctx.performed)
                 //   detenerJump();
            }
        }
        
    }

    private void detenerJump(InputAction.CallbackContext ctx)
    {
        m_rigidbody.velocity = new Vector3(m_rigidbody.velocity.x, m_rigidbody.velocity.y * 0.5f);
    }

    
}
