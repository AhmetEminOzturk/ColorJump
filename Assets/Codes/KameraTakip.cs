using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{

    public Transform topPozisyonu;

    void Update()
    {
        if ( topPozisyonu.position.y > transform.position.y)
        {
            transform.position = new Vector3 (transform.position.x, topPozisyonu.position.y, transform.position.z);
        }

    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
