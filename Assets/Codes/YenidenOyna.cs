using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SearchService;

public class YenidenOyna : MonoBehaviour
{
    public void Yeniden()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    void Start()
    {
        BallMoves.skor = 0;
    }

    
}
