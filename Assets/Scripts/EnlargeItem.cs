using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeItem : MonoBehaviour
{
        public ShedController shedController;
        // Global variables
        Vector3 scaleChange;
        public GameObject pressForInfoText;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(1.0f, 1.0f, 1.0f);
        pressForInfoText.SetActive(false);
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
        pressForInfoText.SetActive(true);
        // If "I" key is pressed, show menu

        if(gameObject.tag == "hoe" && Input.GetKeyDown(KeyCode.I))
        {
            shedController.hoeActive = true;
        }
        else if(gameObject.tag == "shovel" && Input.GetKeyDown(KeyCode.I))
        {
            shedController.shovelActive = true;
        }
        else if(gameObject.tag == "water can" && Input.GetKeyDown(KeyCode.I))
        {
            shedController.watercanActive = true;
        }
        else if(gameObject.tag == "scissors" && Input.GetKeyDown(KeyCode.I))
        {
            shedController.scissorsActive = true;
        }
        else if(gameObject.tag == "sickle" && Input.GetKeyDown(KeyCode.I))
        {
            shedController.sickleActive = true;
        }

    }

    public void OnMouseExit()
    {
        transform.localScale -= scaleChange;
        pressForInfoText.SetActive(false); 
    }
}
