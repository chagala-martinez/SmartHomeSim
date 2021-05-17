using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : Interactable
{
    public GameControl player;
    public AudioSource audioSource;
    public bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<GameControl>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isInsideZone && Input.GetMouseButtonDown(1))
            Interact();
            
    }

    public override void Interact()
    {
        if(!isPlaying)
        {
            Debug.Log("Playing Music...");
            isPlaying=true;
            audioSource.Play();
            player.fun = 100;
            player.MaxFun();
		}
        else
        {
            Debug.Log("Stopping Music...");
			isPlaying=false;
            audioSource.Stop();
        }
    }
}
