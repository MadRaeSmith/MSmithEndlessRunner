using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatController : MonoBehaviour
{
    private bool isJumping = false;
    private float jumpTimer;
    public Rigidbody2D playerRB; // < This is the name of the variable
    public float jumpForce;
    [SerializeField] private Transform FeetPosition;
    [SerializeField] private float groundDistance = 0.25f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float jumpTime = 0.5f;
    public Animator animator;
    public bool isDead = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            playerRB.velocity = Vector2.up * jumpForce;
            isJumping = true;
            animator.SetBool("isJumping", true);
        }

        if (isJumping == true && (Input.GetButton("Jump")))


            if (jumpTimer < jumpTime)
            {
                playerRB.velocity = Vector2.up * jumpForce;

                jumpTimer += Time.deltaTime;
                //Debug.Log(jumpTimer + jumpTime);
            }
            else
            {
                isJumping = false;
                animator.SetBool("isJumping", false);
            }

        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
            jumpTimer = 0f;

        }
    }
}   
    
        
    
    

