using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Global variables
    public GameObject menuPanel;
    public GameObject instructionsPanel;
    public GameObject menuButton;
    public TextMeshProUGUI balanceText;

    static public int balance; 
    static public bool balancePending;

    // Start is called before the first frame update
    void Start()
    {
        menuButton.SetActive(true);
        menuPanel.SetActive(false);
        instructionsPanel.SetActive(false);

        // Set balance to 0 at start
        UpdateBalance(0);
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if(GameObject.Find("GameController") == null)
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update the player's balance
    public void UpdateBalance(int scoreToAdd)
    {
        balance += scoreToAdd;
        balanceText.text = "Balance: $" + balance;
        balancePending = false;
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
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
