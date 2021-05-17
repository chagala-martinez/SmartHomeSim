using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int health;
    private int hygiene;
    private int fun;
    private int energy;
    private int hunger;
    private int bladder;

    public Player(int health, int hygiene, int fun, int energy, int hunger, int bladder)
    {
        this.health = health;
        this.hygiene = hygiene;
        this.fun = fun;
        this.energy = energy;
        this.hunger = hunger;
        this.bladder = bladder;
    }

    public int GetHealth()
    {
        return this.health;
    }

    public int GetHygiene()
    {
        return this.hygiene;
    }

    public int GetFun()
    {
        return this.fun;
    }

    public int GetEnergy()
    {
        return this.energy;
    }

    public int GetHunger()
    {
        return this.hunger;
    }

    public int GetBladder()
    {
        return this.bladder;
    }

    public void SetHealth(int health)
    {
        this.health = health;
    }

    public void SetHygiene(int hygiene)
    {
        this.hygiene = hygiene;
    }

    public void SetFun(int fun)
    {
        this.fun = fun;
    }

    public void SetEnergy(int energy)
    {
        this.energy = energy;
    }

    public void SetHunger(int hunger)
    {
        this.hunger = hunger;
    }

    public void SetBladder(int bladder)
    {
        this.bladder = bladder;
    }

    public void UpdateHealth()
    {
        if(health > 0)
        {
            if(hunger == 0)
            health -= 5;
            if(hygiene == 0)
                health-=2;
            if(energy == 0)
                health -= 5;
            if(fun == 0)
                health -= 1;
            if(bladder == 0)
                health -=3;
        }
    }

    public void UpdateHygiene()
    {
        if(hygiene > 0)
            hygiene--;
    }

    public void UpdateHunger()
    {
        if(hunger > 0)
            hunger--;
    }

    public void UpdateFun()
    {
        if(fun > 0)
            fun--;
    }

    public void UpdateEnergy()
    {
        if(energy > 0)
            energy--;
    }

    public void UpdateBladder()
    {
        if(bladder > 0)
            bladder--;
    }
}