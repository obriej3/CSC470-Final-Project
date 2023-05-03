using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    //Global variables
    Animator anim;
    private Rigidbody rb;

    public GameObject ToolsPanel;

    public AudioSource audioSource;
    public AudioClip step;
    public AudioClip watering;
    public float speed = 2.0f;
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
        //float verticalInput = Input.GetAxis("Vertical");
        //float horizontalInput = Input.GetAxis("Horizontal");
        //transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        transform.Translate((Vector3.forward * Input.GetAxis("Vertical") * speed) * Time.deltaTime);
        //transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed);
        transform.Rotate(new Vector3(0, turnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0));

        // If W key is down, walk forward
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
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

        // If left click, water plant
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetBool("isWatering", true);
        }
        else
        {
            anim.SetBool("isWatering", false);
        }

        // If K key is down, kneel
        if(Input.GetKeyDown(KeyCode.K))
        {
            anim.SetBool("isKneeling", true);
        }
        else
        {
            anim.SetBool("isKneeling", false);
        }
    } 

    private void Step()
    {
        audioSource.volume = 0.05f;
        audioSource.PlayOneShot(step);
    }

    private void StartWatering()
    {
        audioSource.volume = 2.5f;
        audioSource.PlayOneShot(watering);
    }

    private void StopWatering()
    {
        audioSource.Pause();
    }

    // Handles Collision with Farm Plots and Entering the Shed
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("cabbagePlot") && cabbageSeed > 0)
        {
            cabbagePlot.GetComponent<Renderer>().material.color = Color.yellow;
            Debug.Log("HIt");
        }
        
        if (collision.gameObject.CompareTag("shed")) {
            ToolsPanel.SetActive(true);
            //SceneManager.LoadScene("InsideOfShed");
        }

    }
}


