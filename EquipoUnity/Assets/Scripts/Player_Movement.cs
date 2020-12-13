using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidad = 5f;
    public Animator animator;
    public SpriteRenderer sr;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetInteger("Movement_Direction", -1);
        sr = GetComponent<SpriteRenderer>();
    }



    void Update()
    {
        float movimientoh = Input.GetAxis("Horizontal");
        float movimientov = Input.GetAxis("Vertical");

        if (movimientoh == 0 && movimientov == 0)
        {
            animator.SetInteger("Movement_Direction", -1);
            rb.velocity = new Vector2(0, 0);
        }
        else
        {
            if (movimientoh != 0)
            {
                sr.flipX = movimientoh < 0;
                rb.velocity = new Vector2(velocidad * movimientoh, rb.velocity.y);
                
                animator.SetInteger("Movement_Direction", 2);
                
            }

            if (movimientov != 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, movimientov * velocidad);
                if (movimientov > 0)
                {
                    animator.SetInteger("Movement_Direction", 1);
                }
                else
                {
                    animator.SetInteger("Movement_Direction", 0);
                }
            }
        }
        
    }
   
}
