using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
  public TextMeshProUGUI CountText;
   [SerializeField]float speed;
   [SerializeField]float movement;
   [SerializeField]float jumpForce;
   int count;
   bool isFacingRight = true;
   bool isJump = false;
   //reference for rigidbody
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
    private void processInput()
    {
      movement = Input.GetAxis("Horizontal");
      if(Input.GetButtonDown("Jump")) //add the type of the axis(Horizontal, Vertical, Jump)
      {
        isJump=true;
      }
      
    }
    private void move()
    {
      rb.velocity = new Vector2(movement*speed, rb.velocity.y);
      if(isJump)
      {
        rb.AddForce(new Vector2(0f,jumpForce), ForceMode2D.Impulse); //to force the player movement
        isJump = false;
        
      }
    }
    private void animate() 
    {
        if(movement >0 && !isFacingRight)
        {
            Flipcharacter();
        }
        else if(movement<0 && isFacingRight)
        {
          Flipcharacter();
        }
        
    }
    private void Flipcharacter()
    {
      isFacingRight = !isFacingRight;
      transform.Rotate(0f , 180f , 0f);
      // transform.rotate(x,y,z)
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
      CountText.text="Count "+count.ToString();
    }
    
    

    
}
