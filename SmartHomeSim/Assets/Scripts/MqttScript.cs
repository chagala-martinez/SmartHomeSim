using UnityEngine;
using System.Collections;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using UnityEngine.UI;

using System;

public class MqttScript : MonoBehaviour {
	public string brokerEndpoint = "test.mosquitto.org";
	public int brokerPort = 1883;
	public string mainTopic = "smartHome/main";
	private MqttClient client;

	public Text displayText;
	public Lights dinnerLightObject;
	//public GameObject dinnerLightObject;
    public Lights bedroomLightObject;
	string lastMessage;

	volatile bool dinnerLight = false;
	volatile bool lastDinnerLight = false;
    volatile bool bedroomLight = false;
	volatile bool lastBedroomLight = false;

	// Use this for initialization
	void Start () {
		// create client instance 
		client = new MqttClient(brokerEndpoint, brokerPort, false, null); 
		
		// register to message received 
		client.MqttMsgPublishReceived += client_MqttMsgPublishReceived; 
		
		string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId); 
		
		// subscribe to the topic with QoS 2 
		client.Subscribe(new string[] { mainTopic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });  

	}
	void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) 
	{ 
		Debug.Log("Received: " + System.Text.Encoding.UTF8.GetString(e.Message)  );
		lastMessage = System.Text.Encoding.UTF8.GetString(e.Message);
		if(e.Topic.Equals(mainTopic))
		{
			if(lastMessage.Equals("dinner on"))
			{
				Debug.Log("Recibido: On");
				lastDinnerLight = dinnerLight;
                dinnerLight = true;
			}
			else if(lastMessage.Equals("dinner off"))
			{
				Debug.Log("Recibido: off");
				lastDinnerLight = dinnerLight;
                dinnerLight = false;
			}
            
            if(lastMessage.Equals("bedroom on"))
			{
				Debug.Log("Recibido: On");
				lastBedroomLight = bedroomLight;
                bedroomLight = true;
                
			}
			else if(lastMessage.Equals("bedroom off"))
			{
				Debug.Log("Recibido: off");
				lastBedroomLight = bedroomLight;
                bedroomLight = false;
			}
		}
	}

	void Update()
	{
		if(lastDinnerLight != dinnerLight)
			dinnerLightObject.MQTTSetLights(dinnerLight);
		if(lastBedroomLight != bedroomLight)
			bedroomLightObject.MQTTSetLights(bedroomLight);
		// displayText.text = lastMessage;
		// if (dinnerLight != dinnerLightObject.activeSelf)
		// 	dinnerLightObject.SetActive(dinnerLight);
        // if(bedroomLight != bedroomLightObject.activeSelf)
        //     bedroomLightObject.SetActive(bedroomLight);
	}

	// void OnGUI(){
	// 	if ( GUI.Button (new Rect (20,40,80,20), "Level 1")) {
	// 		Debug.Log("sending...");
	// 		client.Publish(mainTopic, System.Text.Encoding.UTF8.GetBytes("lightOn"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
	// 		Debug.Log("sent");
	// 	}
	// }

	// void OnApplicationQuit()
	// {
	// 	client.Disconnect();
	// }
}
