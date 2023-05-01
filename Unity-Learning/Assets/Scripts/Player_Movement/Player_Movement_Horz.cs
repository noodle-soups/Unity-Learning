using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Horz : MonoBehaviour
{

    Rigidbody2D rb;

    float move_speed;
    float input_h;

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
        if (input_h != 0)
        {
            rb.AddForce(new Vector2(move_speed * input_h, 0));
        }
        
    }
}
