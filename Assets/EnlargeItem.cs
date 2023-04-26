using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeItem : MonoBehaviour
{
        // Global variables
        Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(1.0f, 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseEnter()
    {
        transform.localScale += scaleChange;
    }

    public void OnMouseExit()
    {
        transform.localScale -= scaleChange; 
    }
}
