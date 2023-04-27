using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    //Global variables
    Animator anim;
    private Rigidbody rb;

    public AudioSource audioSource;
    public AudioClip step;
    public float turnSpeed = 140.0f;

    // Relevant to Farming
    public int cabbageSeed = 3;
    public GameObject cabbagePlot;

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
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        // If W key is down, walk forward
        if(Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        // If R key is down, run forward
        if(Input.GetKey(KeyCode.R))
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    } 

    private void Step()
    {

        audioSource.PlayOneShot(step);
    }

    // Handles Collision with Farm Plots and Entering the Shed
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("cabbagePlot") && cabbageSeed > 0)
        {
            cabbagePlot.GetComponent<Renderer>().material.color = Color.yellow;
            Debug.Log("HIt");
        }
        
        if (collision.gameObject.CompareTag("Shed")) {
            SceneManager.LoadScene("InsideOfShed");
        }

    }
}


