using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController instance;
    public static GameController Instance { get => instance; }

    private string activePlatform;

    #region Init Objects
    private MainMenuController mainMenuController;

    #endregion

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        cInit();
        StartGame();

        mainMenuController = GetComponentInChildren<MainMenuController>();
    }

    void cInit()
    {
        Debug.Log("Initializing engine...");
        Debug.Log("Initializing Main Menu Controller...");
        mainMenuController.Init();
    }
    void StartGame()
    {
        Debug.Log("Starting game...");
    }

    public string GetActivePlatform()
    {
        activePlatform = Application.productName;
        return activePlatform;
    }
}
