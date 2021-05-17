using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject statsUI;
    public GameObject buttonMenuUI;
    public GameObject pauseMenuUI;
    public GameObject gameOverUI;
    GameControl player;

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        statsUI.SetActive(false);
        buttonMenuUI.SetActive(false);
        gameOverUI.SetActive(false);

        Time.timeScale = 0f;
    }

    public void Resume()
    {
        statsUI.SetActive(true);
        buttonMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        gameOverUI.SetActive(false);
        
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
            statsUI.SetActive(false);
            buttonMenuUI.SetActive(false);
            pauseMenuUI.SetActive(false);
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void Awake()
    {
        player = FindObjectOfType<GameControl>();
    }
}
