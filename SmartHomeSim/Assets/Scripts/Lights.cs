using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public GameObject dinnerLightObject;

    public void MQTTSetLights(bool active)
    {
        if(active)
            dinnerLightObject.SetActive(true);
        else
            dinnerLightObject.SetActive(false);
    }

    public void VoiceSetLights()
    {
        dinnerLightObject.SetActive(!dinnerLightObject.activeSelf);
    }
}
