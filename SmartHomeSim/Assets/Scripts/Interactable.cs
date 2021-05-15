using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool isInsideZone = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown() {         //OnMazda
        Interact();
        Debug.Log("Interaccion OnMouseDown");
    }

    //Is called when the collider other enters the trigger
    //<param name ="other">The other Collider involved in this collision.</param>
     void OnTriggerEnter(Collider other) {
        if(!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = true;
        //Debug.Log("Inside Zone");
    }

    void OnTriggerExit(Collider other) {
        if(!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = false;
        //Debug.Log("Outside Zone");
    }

    public virtual void Interact()
    {
        Debug.Log("Interaccion");
    }
}
