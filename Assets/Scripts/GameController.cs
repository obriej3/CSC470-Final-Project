using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Global variables
    public GameObject menuPanel;
    public GameObject instructionsPanel;
    public GameObject menuButton;

    // Start is called before the first frame update
    void Start()
    {
        menuButton.SetActive(true);
        menuPanel.SetActive(false);
        instructionsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMenu()
    {
        menuPanel.SetActive(true);
        menuButton.SetActive(false);
    }

    public void ExitMenu()
    {
        menuPanel.SetActive(false);
        menuButton.SetActive(true);
    }

    public void LoadInstructions()
    {
        instructionsPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void ExitInstructions()
    {
        instructionsPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
