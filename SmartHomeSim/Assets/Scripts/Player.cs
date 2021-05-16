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

    public void UpdateHealth(bool add)
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

    public void UpdateHygiene(bool add)
    {
        if(hygiene < 100 && add)
        {
            hygiene += 5;
        }
        else if(hygiene > 15 && !add)
        {
            hygiene -= 20;
        }
        else if(hygiene <= 15 && !add)
            hygiene = 0;
    }

    public void UpdateHunger(bool add)
    {
        if(hunger < 100 && add)
        {
            hunger += 5;
        }
        else if(hunger > 20 && !add)
        {
            hunger -= 25;
        }
        else if(hunger <= 20 && !add)
            hunger = 0;
    }

    public void UpdateFun(bool add)
    {
        if(fun < 100 && add)
        {
            fun += 5;
        }
        else if(fun > 20 && !add)
        {
            fun -= 25;
        }
        else if(fun <= 20 && !add)
            fun = 0;
    }

    public void UpdateEnergy(bool add)
    {
        if(energy < 100 && add)
        {
            energy += 5;
        }
        else if(energy > 20 && !add)
        {
            energy -= 25;
        }
        else if(energy <= 20 && !add)
            energy = 0;
    }

    public void UpdateBladder(bool add)
    {
        if(bladder < 100 && add)
        {
            bladder += 5;
        }
        else if(bladder > 20 && !add)
        {
            bladder -= 25;
        }
        else if(bladder <= 20 && !add)
            bladder = 0;
    }
    
}