using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVObject : Interactable
{
    public bool isOn = false;
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
        if(isInsideZone)
        {
            Debug.Log("TV");
            player.play = 100;
            player.MaxPlay();
        }
    }
}
