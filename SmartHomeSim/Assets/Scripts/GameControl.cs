using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public int health = 100;
    public int hygiene = 100;
    public int hunger = 100;
    public int fun = 100;
    public int energy = 100;
    public int bladder = 100;

    public float timerHealth = 0f;
    public float timerHygiene = 0f;
    public float timerHunger = 0f;
    public float timerFun = 0f;
    public float timerEnergy = 0f;
    public float timerBladder = 0f;

    private float maxTimeHealth = 5f; //5
    private float maxTimeHygiene = 5f; //20
    private float maxTimeHunger = 5f; //15
    private float maxTimeFun = 5f; //30
    private float maxTimeEnergy = 5f;
    private float maxTimeBladder = 5f;
    

    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = new Player(health, hygiene, fun, energy, hunger, bladder);
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
            player.UpdateHealth(false);
            health = player.GetHealth();
            timerHealth = 0f;
        }

        if((timerHygiene += Time.deltaTime) >= maxTimeHygiene)
        {
            player.UpdateHygiene(false);
            hygiene = player.GetHygiene();
            timerHygiene = 0f;
        }

        if((timerHunger += Time.deltaTime) >= maxTimeHunger)
        {
            player.UpdateHunger(false);
            hunger = player.GetHunger();
            timerHunger = 0f;
        }

        if((timerFun += Time.deltaTime) >= maxTimeFun)
        {
            player.UpdateFun(false);
            fun = player.GetFun();
            timerFun = 0f;
        }

        if((timerEnergy += Time.deltaTime) >= maxTimeEnergy)
        {
            player.UpdateEnergy(false);
            energy = player.GetEnergy();
            timerEnergy = 0f;
        }

        if((timerBladder += Time.deltaTime) >= maxTimeBladder)
        {
            player.UpdateBladder(false);
            bladder = player.GetBladder();
            timerBladder = 0f;
        }
        
    }

    private void CheckStatus()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.UpdateHealth(true);
            health = player.GetHealth();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.UpdateEnergy(true);
            energy = player.GetEnergy();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            player.UpdateHygiene(true);
            hygiene = player.GetHygiene();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            player.UpdateHunger(true);
            hunger = player.GetHunger();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            player.UpdateFun(true);
            fun = player.GetFun();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            player.UpdateBladder(true);
            bladder = player.GetBladder();
        }
        
    }

    public void MaxHealth()
    {
        player.SetHealth(100);
    }

    public void MaxHygiene()
    {
        player.SetHygiene(100);
    }

    public void MaxHunger()
    {
        player.SetHunger(100);
    }

    public void MaxFun()
    {
        player.SetFun(100);
    }

    public void MaxEnergy()
    {
        player.SetEnergy(100);
    }

    public void MaxBladder()
    {
        player.SetBladder(100);
    }
    
}
