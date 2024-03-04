using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // This is a variable that holds a rigid body component
    //     V This is the class
    public Rigidbody2D playerRB; // < This is the name of the variable
    public float jumpForce;

    [SerializeField] private Transform FeetPosition;
    [SerializeField] private float groundDistance = 0.25f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float jumpTime = 0.5f;
    [SerializeField] private Animator animator;

    private bool isGrounded = true;
    private bool isJumping = false;
    private float jumpTimer;

    // Update is called once per frame
    void Update()
    {

         if (isGrounded = Physics2D.OverlapCircle(FeetPosition.position, groundDistance, groundLayer) == true)
        {
            isGrounded = true;
        }
        else
         {
            isGrounded = false;
          }

        //isGrounded = Physics2D.OverlapCircle(FeetPosition.position, groundDistance, groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            playerRB.velocity = Vector2.up * jumpForce;
            isGrounded = false;
            isJumping = true;
            animator.SetBool("isJumping", true);
            //Check for the animation code when sprites are done
        }

        if (isJumping == true && (Input.GetButton("Jump")))
            
        {
            if(jumpTimer < jumpTime)
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
        }
       if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
            jumpTimer = 0f;

        }
    }
}
