using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PS4Object : Interactable
{
    public GameControl player;

    void Start()
    {
        
        player = FindObjectOfType<GameControl>();
    }

    void Update()
    {
        if(isInsideZone && Input.GetMouseButtonDown(1))
            Interact();
    }

    public override void Interact()
    {
        player.fun = 100;
        player.MaxFun();
        DontDestroyOnLoad(player);
        SceneManager.LoadScene("AR");
    }
}
