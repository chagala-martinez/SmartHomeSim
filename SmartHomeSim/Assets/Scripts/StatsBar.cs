using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsBar : MonoBehaviour
{
    public Image healthBar;
    public Image energyBar;
    public Image hungerBar;
    public Image funBar;
    public Image hygieneBar;
    public Image bladderBar;

    private float health;
    private float hygiene;
    private float hunger;
    private float fun;
    private float energy;
    private float bladder;

    private float maxValue = 100f;
    
    GameControl player;
    Color32 green;
    Color32 yellow;
    Color32 red;
    
    void Start()
    {
        player = FindObjectOfType<GameControl>();
        green = new Color32(35, 200, 50, 255);
        yellow = new Color32(230, 160, 30, 255);
        red = new Color32(255, 50, 50, 255);
    }

    // Update is called once per frame
    void Update()
    {
        health = player.health;
        healthBar.fillAmount = health / maxValue;
        

        hygiene = player.hygiene;
        hygieneBar.fillAmount = hygiene / maxValue;

        fun = player.fun;
        funBar.fillAmount = fun / maxValue;

        hunger = player.hunger;
        hungerBar.fillAmount = hunger / maxValue;

        energy = player.energy;
        energyBar.fillAmount = energy / maxValue;

        bladder = player.bladder;
        bladderBar.fillAmount = bladder / maxValue;

        ChangeColor();

    }

    private void ChangeColor()
    {
        if(health > 65)
            healthBar.color = green;
        else if(health <= 65 && health > 30)
            healthBar.color = yellow;
        else
            healthBar.color = red;

        if(hygiene > 65)
            hygieneBar.color = green;
        else if(hygiene <= 65 && hygiene > 30)
            hygieneBar.color = yellow;
        else
            hygieneBar.color = red;

        if(fun > 65)
            funBar.color = green;
        else if(fun <= 65 && fun > 30)
            funBar.color = yellow;
        else
            funBar.color = red;
        
        if(energy > 65)
            energyBar.color = green;
        else if(energy <= 65 && energy > 30)
            energyBar.color = yellow;
        else
            energyBar.color = red;

        if(hunger > 65)
            hungerBar.color = green;
        else if(hunger <= 65 && hunger > 30)
            hungerBar.color = yellow;
        else
            hungerBar.color = red;
        
        if(bladder > 65)
            bladderBar.color = green;
        else if(bladder <= 65 && bladder > 30)
            bladderBar.color = yellow;
        else
            bladderBar.color = red;

    }
}
