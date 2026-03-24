using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PersonaMoveScript : MonoBehaviour
{
    [Header("Component links")]
    public Rigidbody2D Rb;
    public Animator anim;

    [Header("Move")]
    public float moveSpeed = 5f;
    public float pushSpeed = 1f;

    [HideInInspector] public float speed;
    [HideInInspector] public bool isPushing = false;


    Vector2 moveInput;
    [HideInInspector] public float horizontalInput;
    bool isFacingRight = true;

    [Header ("Jump")]
    public float JumpForce = 10f;

    int maxJump = 2;
    bool isGrounded;
    int jumpRemaining;

    [Header ("Gravity")]
    public float baseGravity = 1f;
    public float maxFallSpeed = 10f; 

    float fallSpeedMultiplier = 2f;

    [Header("Death")]
    bool isDieing = false;
    Transform checkPointTransform;
    CheckPointScript flagScript;
    

    void Start()
    {
        checkPointTransform = GameObject.FindGameObjectWithTag("Respawn").transform;
        flagScript = GameObject.FindGameObjectWithTag("Respawn").GetComponent<CheckPointScript>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        FlipSprite();

        Rb.linearVelocity = new Vector2(moveInput.x * speed, Rb.linearVelocity.y); 
        anim.SetFloat("xVelocity", Math.Abs(Rb.linearVelocity.x));
        anim.SetFloat("yVelocity", (Rb.linearVelocity.y));
        Gravity();
    }

    private void FixedUpdate()
    {
        ReSpawn();
    }

    public void ReSpawn()
    {
        if (flagScript.isFlagPassed && isDieing && horizontalInput > checkPointTransform.position.x )
        {
            isDieing = false;
            anim.SetBool("isPersonaDieing", isDieing);
            gameObject.transform.position = checkPointTransform.position;
        }
    }

    public void FlipSprite()
    {
        if (isFacingRight && horizontalInput < 0 || !isFacingRight && horizontalInput > 0)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1;
            transform.localScale = ls;
        }
    }

    public void Gravity()
    {
        if (Rb.linearVelocity.y < 0)
        {
            Rb.gravityScale = baseGravity * fallSpeedMultiplier;
            Rb.linearVelocity = new Vector2(Rb.linearVelocity.x, Mathf.Max(Rb.linearVelocity.y, -maxFallSpeed));
        }
        else
        {
            Rb.gravityScale = baseGravity;
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        speed = moveSpeed;
        moveInput = context.ReadValue<Vector2>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (jumpRemaining > 0) {
                jumpRemaining--;
                isGrounded = false;
                anim.SetBool("isGrounded", !isGrounded);
                Rb.linearVelocity = new Vector2(Rb.linearVelocity.x, JumpForce);
            }
        }
    }
    public void Hit()
    {
        anim.SetBool("isPersonaDieing", true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DeathTrigger"))
        {
            isDieing = true;
            anim.SetBool("isPersonaDieing", isDieing);
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            isPushing = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            isPushing = false;
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
        anim.SetBool("isGrounded", !isGrounded);
        jumpRemaining = maxJump;
    }
}


////////////////// WallSlide ///////////////////

/*if (wallCollider.isTrigger)
        {
            isWallTrigger = true;
            anim.SetBool("isSliding", isWallTrigger);
        }
        else
        {
            Debug.Log("non trigger");
            isWallTrigger = false;
            anim.SetBool("isSliding", isWallTrigger);
        }*/
