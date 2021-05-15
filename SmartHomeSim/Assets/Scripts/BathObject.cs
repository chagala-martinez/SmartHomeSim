using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathObject : Interactable
{
    //public Player player;
    
    // Start is called before the first frame update
    void Start()
    {
        //player = GetComponent<Player>();       //no
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if(isInsideZone)            //declarado en Interactable
        {
            Debug.Log("Bath");
            //player.SetClean(100);
        }
    }

}
