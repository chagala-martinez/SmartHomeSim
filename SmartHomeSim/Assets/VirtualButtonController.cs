using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonController : MonoBehaviour, IVirtualButtonEventHandler
{
    GameControl player;
    public GameObject btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.Find("HealthButton");
        btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        player = FindObjectOfType<GameControl>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Health: 100%");
        player.health = 100;
        player.MaxHealth();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
    }
}
