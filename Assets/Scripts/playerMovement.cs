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
    public float turnSpeed = 140.0f;

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
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    } 

    private void Step()
    {

        audioSource.PlayOneShot(step);
    }

}
