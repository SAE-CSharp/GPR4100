using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI CountText;
    public float speed; 
    public float movement;
    public float jumpForce;
    int count;
    bool isFacingRight = true;
    bool isJump = false;
    //Create reference to the rigidbody 2D
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        processInput();


        move();
        animate();
   
    }
    private void animate()
    {
       if(movement > 0 && !isFacingRight)
       {
          FlipCharacter();
       }
       else if(movement < 0 && isFacingRight)
       {
           FlipCharacter();
       }
    }

    private void FlipCharacter()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f,180f,0f);
        // transform.Rotate(x,y,z);
    }
    private void move()
    {
        rb.velocity = new Vector2(movement * speed, rb.velocity.y);

        if(isJump)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);  //To force the player's movement
            isJump = false;
        }
    }
    private void processInput()
    {
        movement = Input.GetAxis("Horizontal");
        
        if(Input.GetButtonDown("Jump")) //Add the type of the Axes(Horizontal, Vertical, Jump)
        {
            isJump = true;
        }
    }

      private void OnTriggerEnter2D(Collider2D collision)
        {
            collision.gameObject.CompareTag("Coins");
            collision.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }

        private void SetCountText()
        {
            CountText.text = "Count - " + count.ToString();
        }
}

