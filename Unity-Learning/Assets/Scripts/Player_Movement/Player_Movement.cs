using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{


    // Fields
    Rigidbody2D rb;
    private float move_speed;
    private float jump_force;
    private bool is_jumping;
    private float move_horizontal;
    private float move_vertical;



    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        move_speed = 3f;
        jump_force = 60f;
        is_jumping = false;
        
    }



    // Update is called once per frame
    void Update()
    {

        move_horizontal = Input.GetAxisRaw("Horizontal");
        move_vertical = Input.GetAxisRaw("Vertical");
   
    }


    // Fixed Update
    void FixedUpdate()
    {

        if (move_horizontal > 0.1f || move_horizontal < 0.1f)
        {
            rb.AddForce(new Vector2(move_horizontal * move_speed, 0f), ForceMode2D.Impulse);
        }

        if (!is_jumping && move_vertical > 0.1f)
        {
            rb.AddForce(new Vector2(0f, move_vertical * jump_force), ForceMode2D.Impulse);
        }

    }



    /* Enabling jump while colliding with platform:
        - is_jumping needs to be false to unlock jump
        - collides with platform --> is_jump == false
        - unlocks jump ability
     */
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            is_jumping = false;
        }
    }


    /* Disabling jump in air:
        - after exiting platform collision
        - is_jump == true
        - jump logic locked when true
    */
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            is_jumping = true;
        }
    }
}
