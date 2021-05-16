using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HygieneObject : Interactable
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
        if(isInsideZone && Input.GetMouseButtonDown(1))
            Interact();
    }

    public override void Interact()
    {
        Debug.Log("Shower");
        player.hygiene = 100;
        player.MaxHygiene();
    }

}
