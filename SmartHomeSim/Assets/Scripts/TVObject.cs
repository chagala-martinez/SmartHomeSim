using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVObject : Interactable
{
    public bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
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
        }
    }
}
