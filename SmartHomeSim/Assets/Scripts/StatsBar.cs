using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsBar : MonoBehaviour
{
    public Image healthBar;
    public Image foodBar;
    public Image playBar;
    public Image cleanBar;
    private float health;
    private float play;
    private float clean;
    private float food;

    private float maxValue = 100f;
    
    GameControl player;
    
    void Awake()
    {
        player = FindObjectOfType<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        health = player.health;
        healthBar.fillAmount = health / maxValue;

        play = player.play;
        playBar.fillAmount = play / maxValue;

        food = player.food;
        foodBar.fillAmount = food / maxValue;

        clean = player.clean;
        cleanBar.fillAmount = clean / maxValue;

    }
}
