using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonDevamButon : MonoBehaviour
{
    public GameObject SonDevampanel;

    void Start() 
    {
        SonDevampanel.SetActive(false);   
    }


    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "Karakter")
        {
            SonDevampanel.SetActive(true);
            Time.timeScale = 0;
        }    
    }
}
