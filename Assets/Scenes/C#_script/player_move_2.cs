using UnityEngine;
using System.Collections;

public class player_move_2 : MonoBehaviour
{
    public float jumpForce;
    public float speed;
    public Rigidbody2D rb;
    public float inputHorizontal;
    public float inputVertical;
    public float distance;
    public LayerMask whatIsLadder;
    private bool isClimbing;
    public bool facingRight = true;
    private Animator anim;
    public LayerMask whatIsGround;
    public float checkRadius;
    public Transform groundCheck;
    private bool isGrounded;
    public int extraJumpsValue;
    private int extraJumps;
    public GameObject player;
    public GameObject gun;


    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        gun = GameObject.Find("gun");
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(inputHorizontal * speed, rb.velocity.y);

        if(inputHorizontal == 0)
        {
            anim.SetBool("move", false);
        }
        else
        {
            anim.SetBool("move", true);
        }

        if ( (!facingRight && inputHorizontal > 0) || (facingRight && inputHorizontal < 0))
        {
            Flip();
        }
    
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance,whatIsLadder);
        
        if (hitInfo.collider && hitInfo.collider.CompareTag("ladders"))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                isClimbing = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                isClimbing = false;
            }

        }

        if (isClimbing == true && hitInfo.collider && hitInfo.collider.CompareTag("ladders"))
        {
            inputVertical = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, inputVertical * speed);
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = 1;
        }

    }

    void Update()
    {
        
        if (isGrounded == true)
        {
            extraJumps = 2;
        }


        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            SoundManagerScript.PlaySounds("jump");
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
        {
            SoundManagerScript.PlaySounds("jump");
            rb.velocity = Vector2.up * jumpForce;
        }  
    }

    public void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        var Pointer = gun.transform.rotation;
        Scaler.x *= -1;
        transform.localScale = Scaler;
        if(Scaler.x < 0)
        {
            Scaler = gun.transform.localScale;
            Scaler.x *= -1;
            gun.transform.localScale = Scaler;
        }
        else
        {
            Pointer.z *= -1;
        }

        gun.transform.rotation = Pointer;
    }
}
