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

    private float timerHealth = 0f;
    private float timerHygiene = 0f;
    private float timerHunger = 0f;
    private float timerFun = 0f;
    private float timerEnergy = 0f;
    private float timerBladder = 0f;

    private float maxTimeHealth = 5f; // Pendiente
    private float maxTimeHygiene = 2.7f; // 3 veces - 4.5 minutos
    private float maxTimeHunger = 1.2f; // 3 veces  - 2 minutos
    private float maxTimeFun = 2.1f; // 5 veces     - 3.5 minutos
    private float maxTimeEnergy = 2.4f; // 1 vez    - 4 minutos
    private float maxTimeBladder = 1.8f; // 2 veces - 3 minutos

    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = new Player(health, hygiene, fun, energy, hunger, bladder);
    }

    // Update is called once per frame
    void Update()
    {
        //CheckStatus();
        CheckTime();
        
    }

    private void CheckTime()
    {
        if((timerHealth += Time.deltaTime) >= maxTimeHealth)
        {
            player.UpdateHealth();
            health = player.GetHealth();
            timerHealth = 0f;
        }

        if((timerHygiene += Time.deltaTime) >= maxTimeHygiene)
        {
            player.UpdateHygiene();
            hygiene = player.GetHygiene();
            timerHygiene = 0f;
        }

        if((timerHunger += Time.deltaTime) >= maxTimeHunger)
        {
            player.UpdateHunger();
            hunger = player.GetHunger();
            timerHunger = 0f;
        }

        if((timerFun += Time.deltaTime) >= maxTimeFun)
        {
            player.UpdateFun();
            fun = player.GetFun();
            timerFun = 0f;
        }

        if((timerEnergy += Time.deltaTime) >= maxTimeEnergy)
        {
            player.UpdateEnergy();
            energy = player.GetEnergy();
            timerEnergy = 0f;
        }

        if((timerBladder += Time.deltaTime) >= maxTimeBladder)
        {
            player.UpdateBladder();
            bladder = player.GetBladder();
            timerBladder = 0f;
        }
        
    }

    private void CheckStatus()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.UpdateHealth();
            health = player.GetHealth();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.UpdateEnergy();
            energy = player.GetEnergy();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            player.UpdateHygiene();
            hygiene = player.GetHygiene();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            player.UpdateHunger();
            hunger = player.GetHunger();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            player.UpdateFun();
            fun = player.GetFun();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            player.UpdateBladder();
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
