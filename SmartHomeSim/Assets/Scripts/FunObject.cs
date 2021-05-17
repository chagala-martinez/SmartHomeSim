﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunObject : Interactable
{
    public bool isOn = false;
    public GameControl player;
    public GameObject tvPlane; 

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
        Debug.Log("Watching TV!!!");
        player.fun = 100;
        player.MaxFun();

        tvPlane.SetActive(!tvPlane.activeSelf); //activa o desactiva TV
    }
}
