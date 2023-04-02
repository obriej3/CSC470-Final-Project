using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //Global variables
    Animator anim;
    private Rigidbody rb;

    public AudioSource audioSource;
    public AudioClip step;

    // Start is called before the first frame update
    void Start()
    {
        // Assign component to the animator
        anim = GetComponent<Animator>();
        
        // Assign component to the rigid body
        rb = GetComponent<Rigidbody>(); 
    }
    
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // If W key is down, walk forward
        if(Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        /* // If S key is down, walk backwards
        if(Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isWalkingBackwards", true);
        }
        else
        {
            anim.SetBool("isWalkingBackwards", false);
        }

        // If D key is down, strafe right
        if(Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isStrafingRight", true);
        }
        else
        {
            anim.SetBool("isStrafingRight", false);
        }

        // If A key is down, strafe left
        if(Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isStrafingLeft", true);
        }
        else
        {
            anim.SetBool("isStrafingLeft", false);
        }

        if(anim.GetBool("isRunning") == false & anim.GetBool("isJumping") == false & anim.GetBool("isWalkingBackwards") == false & anim.GetBool("isStrafingRight") == false & anim.GetBool("isStrafingLeft") == false)
        {
            anim.SetBool("isIdle", true);
        }

        if(Input.GetKeyDown(KeyCode.Mouse0) & anim.GetBool("isIdle") == true)
        {
            anim.SetBool("isAttacking", true);
        }
        else
        {
            anim.SetBool("isAttacking", false);
        }
        */
    } 

    private void Step()
    {

        audioSource.PlayOneShot(step);
    }

}
