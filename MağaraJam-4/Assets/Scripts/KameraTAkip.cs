using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTAkip : MonoBehaviour
{
    public GameObject TakipEt;
    public Vector3 KameraMesafesi;

    void Update()
    {
        transform.position = TakipEt.transform.position + KameraMesafesi;   
    }
}
