using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToolContoller : MonoBehaviour
{
    [HideInInspector]
    public bool hoeSelected;
    [HideInInspector]
    public bool shovelSelected;
    [HideInInspector]
    public bool watercanSelected;
    [HideInInspector]
    public bool scissorsSelected;
    [HideInInspector]
    public bool sickleSelected;

    // Tools' icons
    public GameObject hoeIcon;
    public GameObject shovelIcon;
    public GameObject watercanIcon;
    public GameObject scissorsIcon;
    public GameObject sickleIcon;

    public int toolsSelected;
    public GameObject FullInventoryPopUp;
    public GameObject DuplicateToolPopUp;
    public GameObject ToolsPanel;

    public static InventoryManager Instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoeSelected()
    {
        if(toolsSelected < 3)
        {
            if(hoeSelected == false)
            {
                hoeSelected = true;
                toolsSelected++;
                hoeIcon.SetActive(true);
            }
            else{
                DuplicateToolPopUp.SetActive(true);
            }
        }
        else{
            FullInventoryPopUp.SetActive(true);
        }
    }

    public void HoeRemoved()
    {
        hoeSelected = false;
        toolsSelected--;
        hoeIcon.SetActive(false);
    }

    public void ShovelSelected()
    {
        if(toolsSelected < 3)
        {
            if(shovelSelected == false){
                shovelSelected = true;
                toolsSelected++;
                shovelIcon.SetActive(true);
            }
            else{
                DuplicateToolPopUp.SetActive(true);
            }
            
        }
        else{
            FullInventoryPopUp.SetActive(true);
        }
    }

    public void ShovelRemoved()
    {
        shovelSelected = false;
        toolsSelected--;
        shovelIcon.SetActive(false);
    }

    public void WaterCanSelected()
    {
        if(toolsSelected < 3)
        {
            if(watercanSelected == false)
            {
                watercanSelected = true;
                toolsSelected++;
                watercanIcon.SetActive(true);
            }
            else{
                DuplicateToolPopUp.SetActive(true);
            }
            
        }
        else{
            FullInventoryPopUp.SetActive(true);
        }
    }

    public void WaterCanRemoved()
    {
        watercanSelected = false;
        toolsSelected--;
        watercanIcon.SetActive(false);
    }

    public void ScissorsSelected()
    {
        if(toolsSelected < 3)
        {
            if(scissorsSelected == false)
            {
                scissorsSelected = true;
                toolsSelected++;
                scissorsIcon.SetActive(true);
            }
            else{
                DuplicateToolPopUp.SetActive(true);
            }
        }
        else{
            FullInventoryPopUp.SetActive(true);
        }
    }

    public void ScissorsRemoved()
    {
        scissorsSelected = false;
        toolsSelected--;
        scissorsIcon.SetActive(false);
    }

    public void SickleSelected()
    {
        if(toolsSelected < 3)
        {
            if(sickleSelected == false)
            {
                sickleSelected = true;
                toolsSelected++;
                sickleIcon.SetActive(true);
            }
            else{
                DuplicateToolPopUp.SetActive(true);
            }
        }
        else{
            FullInventoryPopUp.SetActive(true);
        }
    }

    public void SickleRemoved()
    {
        sickleSelected = false;
        toolsSelected--;
        sickleIcon.SetActive(false);
    }

    public void ExitFullInventoryPanel()
    {
        FullInventoryPopUp.SetActive(false);
    }

    public void ExitToolPanel()
    {
        ToolsPanel.SetActive(false);
    }

    public void ExitDuplicateTool()
    {
        DuplicateToolPopUp.SetActive(false);
    }
}
