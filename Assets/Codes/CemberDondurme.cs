using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CemberDondurme : MonoBehaviour
{
    public static float dondurmeHiz = 2f;
    //void Update()
    //{
    //    transform.Rotate(0f, 0f, dondurmeHiz);
    //}
    private void FixedUpdate()
    {
        transform.Rotate(0f, 0f, dondurmeHiz);
    }
}
