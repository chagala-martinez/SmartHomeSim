using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodObject : Interactable
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

    void OnMouseDown()
    {
        if(isInsideZone)            //declarado en Interactable
        {
            Debug.Log("Food");
            player.food = 100;
            player.MaxFood();
        }
    }
}
