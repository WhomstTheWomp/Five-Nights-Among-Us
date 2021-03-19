using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
//using System.Runtime.Hosting;
//using System.Diagnostics;
//using System.Runtime.Remoting.Activation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAY : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        Debug.Log("Starting");
    }

    public void Quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}

