using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PS4Controller : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void BackToScene()
    {
        Debug.Log("BACK");
        SceneManager.LoadScene("Main");
    }
}
