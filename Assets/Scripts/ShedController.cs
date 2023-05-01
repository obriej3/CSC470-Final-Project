using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShedController : MonoBehaviour
{
    // Global variables
    public GameObject hoeInfo;
    public GameObject shovelInfo;
    public GameObject watercanInfo;
    public GameObject scissorsInfo;
    public GameObject sickleInfo;
    public GameObject shedInfo;

    public bool hoeActive;
    public bool shovelActive;
    public bool watercanActive;
    public bool scissorsActive;
    public bool sickleActive;

    // Start is called before the first frame update
    void Start()
    {
        hoeActive = false;
        shovelActive = false;
        watercanActive = false;
        scissorsActive = false;
        sickleActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(hoeActive == true){
            hoeInfo.SetActive(true);
        }

        if(shovelActive == true){
            shovelInfo.SetActive(true);
        }

        if(watercanActive == true){
            watercanInfo.SetActive(true);
        }

        if(scissorsActive == true){
            scissorsInfo.SetActive(true);
        }

        if(sickleActive == true){
            sickleInfo.SetActive(true);
        }
    }

    // Methods for exiting tools' pop-ups
    public void ExitHoeInfo()
    {
        hoeActive = false;
        hoeInfo.SetActive(false);
    }

    public void ExitShovelInfo()
    {
        shovelActive = false;
        shovelInfo.SetActive(false);
    }
    
    public void ExitWaterCanInfo()
    {
        watercanActive = false;
        watercanInfo.SetActive(false);
    }

    public void ExitScissorsInfo()
    {
        scissorsActive = false;
        scissorsInfo.SetActive(false);
    }

    public void ExitSickleInfo()
    {
        sickleActive = false;
        sickleInfo.SetActive(false);
    }

    public void OpenShedInfo()
    {
        shedInfo.SetActive(true);
    }
    
    public void ExitShedInfo()
    {
        shedInfo.SetActive(false);
    }
}
