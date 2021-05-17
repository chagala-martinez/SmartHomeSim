using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool isInsideZone;

    // Start is called before the first frame update
    void Start()
    {
        isInsideZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Is called when the collider other enters the trigger
    //<param name ="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider obj)
    {
        if(obj.tag == "Player")
            isInsideZone = true;
    }

    void OnTriggerExit(Collider obj)
    {
        if(obj.tag == "Player")
            isInsideZone = false;
    }

    public virtual void Interact()
    {
        
    }
}
