using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int health;
    private int food;
    private int play;
    private int clean;

    public Player(int health, int food, int play, int clean)
    {
        this.health = health;
        this.food = food;
        this.play = play;
        this.clean = clean;
    }

    public int GetHealth()
    {
        return this.health;
    }

    public int GetFood()
    {
        return this.food;
    }

    public int GetPlay()
    {
        return this.play;
    }

    public int GetClean()
    {
        return this.clean;
    }

    public void SetHealth(int health)
    {
        this.health = health;
    }

    public void SetFood(int food)
    {
        this.food = food;
    }

    public void SetPlay(int play)
    {
        this.play = play;
    }

    public void SetClean(int clean)
    {
        this.clean = clean;
    }

    public void ModifyHealth(bool add)
    {
        if(health < 100 && add)
        {
            health += 5;
        }
        else if(health > 15 && !add)
        {
            health -= 20;
        }
        else if(health <= 15 && !add)
            health = 0;
    }

    public void ModifyFood(bool add)
    {
        if(food < 100 && add)
        {
            food += 5;
        }
        else if(food > 20 && !add)
        {
            food -= 25;
        }
        else if(food <= 20 && !add)
            food = 0;
    }

    public void ModifyPlay(bool add)
    {
        if(play < 100 && add)
        {
            play += 5;
        }
        else if(play > 20 && !add)
        {
            play -= 25;
        }
        else if(play <= 20 && !add)
            play = 0;
    }

    public void ModifyClean(bool add)
    {
        if(clean < 100 && add)
        {
            clean += 5;
        }
        else if(clean > 15 && !add)
        {
            clean -= 20;
        }
        else if(clean <= 15 && !add)
            clean = 0;
    }
}