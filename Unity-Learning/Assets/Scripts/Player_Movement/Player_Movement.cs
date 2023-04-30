using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    Rigidbody2D rb;

    float move_speed;
    float input_h;
    float input_v;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        move_speed = 10.0f;
        
    }

    // Update is called once per frame
    void Update()
    {

        input_h = Input.GetAxisRaw("Horizontal");
        input_v = Input.GetAxisRaw("Vertical");


        if (input_h != 0)
        {
            rb.AddForce(new Vector2(move_speed * input_h, 0));
        }

        if (input_v != 0)
        {
            rb.AddForce(new Vector2(0, move_speed * input_v));
        }
        
    }
}
