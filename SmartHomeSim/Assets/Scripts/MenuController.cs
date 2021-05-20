using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject statsUI;
    public GameObject gameOverUI;
    public GameObject controlMenuUI;

    GameControl player;

    public void Pause()
    {
        controlMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);

        Time.timeScale = 0f;
    }

    public void Resume()
    {
        controlMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Debug.Log("Quitting game...");
    }

    public void GameOver()
    {
        Debug.Log("New Game...");
    }

    void Update()
    {
        if(Input.GetKeyDown("space"))
            statsUI.SetActive(!statsUI.activeSelf);

        if(player.health <= 0)
        {
            controlMenuUI.SetActive(false);
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void Awake()
    {
        player = FindObjectOfType<GameControl>();
    }
}
