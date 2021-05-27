using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunObject : Interactable
{
    public bool isOn;
    public GameControl player;
    public GameObject tvPlane;

    private float maxTime = 5f;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
        player = FindObjectOfType<GameControl>();
    }

    // Update is called once per frame
    public void Update()
    {
        if(isOn && isInsideZone)
        {
            if((timer += Time.deltaTime) >= maxTime)
            {
                timer = 0f;
                isOn = false;
                PlayTv();
                Interact();
            }
        }
        else if(!isInsideZone)
        {
            timer = 0f;
            isOn = false;
            PlayTv();
        }
        else if(isInsideZone && (Input.GetMouseButtonDown(1) && !isOn))
        {
            Debug.Log("Watching TV!!!");
            isOn = true;
            PlayTv();
        }
            
    }

    public override void Interact()
    {
        player.fun = 100;
        player.MaxFun();
    }

    private void PlayTv()
    {
        if(isOn)
            tvPlane.SetActive(true);
        else
            tvPlane.SetActive(false);
    }

    public void VoiceSetTV()
    {
        tvPlane.SetActive(!tvPlane.activeSelf);
        Interact();
    }
}
