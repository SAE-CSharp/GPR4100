using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Player : MonoBehaviour
{
    bool Grounded;
    //Instance of textmeshpro
    [SerializeField]TextMeshProUGUI loseText;
    //create reference for Rigidbody2D & Animator
    Animator anim;
    Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] float jump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    
        // for movement
        float movement = Input.GetAxis("Horizontal");
        rb.velocity=new Vector2(movement*speed,rb.velocity.y);
        
        //for flipping the character to the left
        if(movement > 0.01f)
        {
          transform.localScale = new Vector3(2,2,1);
        }
        else if(movement < -0.01f)
        {
            transform.localScale=new Vector3(-2,2,1);
        }
        //for jumping
        if(Input.GetKey(KeyCode.Space));
        {
            Jump();
            rb.AddForce(new Vector2(rb.velocity.x,jump));
        }
        anim.SetBool("Run",movement !=0);
        anim.SetBool("Grounded", Grounded);
        
    }
    void Jump()
    {
        rb.AddForce(new Vector2(rb.velocity.x,jump));
        Grounded = false;
    }
    void SetLoseText()
    {
        loseText.text = "Game Over";
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Grounded = true;
        }

        if(collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject,0.07f);
            SetLoseText();
        }
       
    }

    

}
