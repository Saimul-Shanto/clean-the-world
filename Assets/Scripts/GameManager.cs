using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [HideInInspector]
    public bool gameStarted;
    [HideInInspector]
    public bool canAppear;
    
    void Awake()
    {
        instance = this;
    }
    
    public void StartGame()
    {
        // instance = this;
        gameStarted = true;
        canAppear = false;

    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
    }
}
