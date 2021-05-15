using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public float timerHealth = 0f;
    public float timerFood = 0f;
    public float timerPlay = 0f;
    public float timerClean = 0f;
    private float maxTimeHealth = 5f; //5
    private float maxTimeFood = 5f; //15
    private float maxTimePlay = 5f; //30
    private float maxTimeClean = 5f; //20
    public int health = 100;
    public int food = 100;
    public int play = 100;
    public int clean = 100;

    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = new Player(health, food, play, clean);
    }

    // Update is called once per frame
    void Update()
    {
        CheckStatus();
        CheckTime();
    }

    private void CheckTime()
    {
        if((timerHealth += Time.deltaTime) >= maxTimeHealth)
        {
            player.ModifyHealth(false);
            health = player.GetHealth();
            timerHealth = 0f;
        }

        if((timerFood += Time.deltaTime) >= maxTimeFood)
        {
            player.ModifyFood(false);
            food = player.GetFood();
            timerFood = 0f;
        }

        if((timerPlay += Time.deltaTime) >= maxTimePlay)
        {
            player.ModifyPlay(false);
            play = player.GetPlay();
            timerPlay = 0f;
        }

        if((timerClean += Time.deltaTime) >= maxTimeClean)
        {
            player.ModifyClean(false);
            clean = player.GetClean();
            timerClean = 0f;
        }
    }

    private void CheckStatus()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.ModifyHealth(true);
            health = player.GetHealth();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            player.ModifyFood(true);
            food = player.GetFood();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            player.ModifyPlay(true);
            play = player.GetPlay();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            player.ModifyClean(true);
            clean = player.GetClean();
        }
    }

    public void MaxHealth()
    {
        player.SetHealth(100);
    }

    public void MaxFood()
    {
        player.SetFood(100);
    }

    public void MaxPlay()
    {
        player.SetPlay(100);
    }

    public void MaxClean()
    {
        player.SetClean(100);
    }
    
}
