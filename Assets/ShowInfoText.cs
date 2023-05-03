using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfoText : MonoBehaviour
{
    public GameObject pressForInfoText;
    private bool infoActive;
    public GameObject infoPanel;

    public void OnMouseOver()
    {
        // Text for more info appears
        pressForInfoText.SetActive(true);
        infoActive = true;
    }

    public void OnMouseExit()
    {
        pressForInfoText.SetActive(false); 
        infoActive = false;
    }

    public void ExitInfo()
    {
        infoPanel.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(infoActive == true && Input.GetKeyDown(KeyCode.I))
        {
            infoPanel.SetActive(true);
        }
    }
}
