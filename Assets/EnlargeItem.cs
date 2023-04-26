using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeItem : MonoBehaviour
{
        public ShedController shedController;
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

    public void OnMouseOver()
    {
        // Text for more info appears

        // If "I" key is pressed, show menu

    }

    public void OnMouseExit()
    {
        transform.localScale -= scaleChange; 
    }
}
