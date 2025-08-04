using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float jumpForce = 10.0f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius = 0.2f;
    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private PlayerInputActions inputActions;
    private InputAction jumpAction;
    private Vector2 moveInput;
    private bool isGrounded = true;

    [SerializeField] private bool isAlive = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        inputActions = new PlayerInputActions();
        jumpAction = inputActions.Player.Jump;
        inputActions.Player.Enable();

        jumpAction.performed += OnJumpPerformed;
    }

    private void OnDestroy()
    {
        if (jumpAction != null)
            jumpAction.performed -= OnJumpPerformed;

        if (inputActions != null)
            inputActions.Player.Disable();
    }

    private void Update()
    {
        if (inputActions == null) return;

        moveInput = inputActions.Player.Move.ReadValue<Vector2>();
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        if (Mathf.Abs(moveInput.x) > 0.1f && isGrounded)
        {
            animator.SetBool("IsRun", true);
        }

        if (moveInput.x != 0)
        {
            transform.localScale = new Vector3(moveInput.x < 0 ? -1 : 1, 1, 1);
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInput.x * speed, rb.linearVelocity.y);
    }

    private void OnJumpPerformed(InputAction.CallbackContext ctx)
    {
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetBool("IsJump", true);
            isGrounded =false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded =true;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); 
            
            isAlive = false;
            Debug.Log("IsAlive: " + isAlive);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
        }
    }


}