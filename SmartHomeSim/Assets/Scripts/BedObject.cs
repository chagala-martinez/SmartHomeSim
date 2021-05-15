using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedObject : Interactable
{

    public GameControl player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        if(isInsideZone)
        {
            Debug.Log("ZZZZ");
            player.health = 100;
            player.MaxHealth();
        }
    }
}
