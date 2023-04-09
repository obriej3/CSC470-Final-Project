using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Global variables 
    // public GameObject player;
    public Transform target;
    // private Vector3 offset;
    private float pLerp = 0.02f;
    private float rLerp = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        // offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
    }

    // LateUpdate is called after Update each frame
    void Update() 
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        //transform.position = player.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, target.position, pLerp);
        
        // Rotate
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, rLerp);
    }
}
