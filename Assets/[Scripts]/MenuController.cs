using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    public void OnStartButton_Pressed()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnBackButton_Pressed()
    {
        SceneManager.LoadScene("Start");
    }

    public void OnInstructionsButton_Pressed()
    {
        SceneManager.LoadScene("Instructions");
    }
}
