using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSc : MonoBehaviour
{
  
    public void Startbutton()
    {
        SceneManager.LoadScene(1);
    }

    public void Exitbutton()
    {
        Application.Quit();
    }
}
